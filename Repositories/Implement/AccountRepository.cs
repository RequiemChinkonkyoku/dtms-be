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
        
        var assignments = await _context.TrainerAssignments
            .Include(ta => ta.Class)
                .ThenInclude(c => c.Slots)
            .Where(ta =>
                ta.Class.StartingDate <= endDate &&
                ta.Class.Slots.Any(s =>
                    s.Date >= request.StartingDate &&
                    s.Date <= endDate))
            .ToListAsync();
        
        var busyTrainerIds = assignments
            .SelectMany(ta => ta.Class.Slots
                .Where(s => request.SlotData.Any(sr =>
                    sr.DayOfWeek == s.Date.DayOfWeek &&
                    sr.ScheduleId == s.ScheduleId))
            .Select(_ => ta.TrainerId)  
            .Distinct()
            .ToList());
        
        return await _context.Accounts
            .Include(a => a.Role)
            .Where(a =>
                (a.Role.Name == "Trainer_Lead" || a.Role.Name == "Trainer_Member") &&
                !busyTrainerIds.Contains(a.Id))
            .ToListAsync();
    }

    public async Task<List<Account>> GetStaffAccountsAsync()
    {
        return await _context.Accounts
                        .AsSplitQuery()
                        .Include(a => a.Role)
                        .Where(a => a.Role.Name == "Staff_Employee" ||
                                    a.Role.Name == "Staff_Manager" ||
                                    a.Status == 1)
                        .ToListAsync();
    }
}