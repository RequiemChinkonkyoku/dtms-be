using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implement
{
    public class ScheduleRepository : RepositoryBase<Schedule>, IScheduleRepository
    {
        public async Task<List<Schedule>> GetAllSchedulesAsync()
        {
            return await _context.Schedules
                .AsSplitQuery()
                .Include(s => s.Slots)
                .Include(s => s.Availabilities)
                .ToListAsync();
        }
        public async Task<Schedule> GetScheduleById(string scheduleId)
        {
            return await _context.Schedules
                .AsSplitQuery()
                .Include(s => s.Slots)
                .Include(s => s.Availabilities)
                .FirstOrDefaultAsync(s => s.Id == scheduleId);
        }

        public async Task<bool> IsScheduleOverlappingAsync(TimeOnly startTime, TimeOnly endTime)
        {
            return await _context.Schedules
                .AnyAsync(s =>
                    (s.StartTime < endTime && s.EndTime > startTime) 
                );
        }
    }
}
