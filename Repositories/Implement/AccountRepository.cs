using Microsoft.EntityFrameworkCore;
using Models.DTOs;
using Models.DTOs.Response;
using Models.Entities;
using Repositories.Interface;

namespace Repositories.Implement;

public class AccountRepository : RepositoryBase<Account>, IAccountRepository
{
    public async Task<List<Account>> GetAvailableTrainersAsync(
            TrainerAvailabilityRequest request)
    {
        var endDate = request.StartingDate.AddDays(request.DurationInWeeks * 7);

        // Step 1: Get all trainer assignments with overlapping classes
        var assignments = await _context.TrainerAssignments
            .Include(ta => ta.Class)
                .ThenInclude(c => c.Slots)
            .Where(ta =>
                ta.Class.StartingDate <= endDate &&
                ta.Class.Slots.Any(s =>
                    s.Date >= request.StartingDate &&
                    s.Date <= endDate))
            .ToListAsync();

        // Step 2: Find busy trainers (client-side evaluation)
        var busyTrainerIds = assignments
            .SelectMany(ta => ta.Class.Slots
                .Where(s => request.SlotData.Any(sr =>
                    sr.DayOfWeek == s.Date.DayOfWeek &&
                    sr.ScheduleId == s.ScheduleId))
            .Select(_ => ta.TrainerId)  // Changed from previous version
            .Distinct()
            .ToList());

        // Step 3: Get available trainers
        return await _context.Accounts
            .Include(a => a.Role)
            .Where(a =>
                (a.Role.Name == "Trainer_Lead" || a.Role.Name == "Trainer_Member") &&
                !busyTrainerIds.Contains(a.Id))
            .ToListAsync();
    }
}