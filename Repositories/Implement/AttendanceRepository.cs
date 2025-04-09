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
    public class AttendanceRepository : RepositoryBase<Attendance>, IAttendanceRepository
    {
        public async Task<List<Attendance>> GetAllAttendancesAsync()
        {
            return await _context.Attendances
                .AsSplitQuery()
                .Include(a => a.Slot)
                .Include(a => a.Dog)
                .Include(a => a.ProgressReports)
                    .ThenInclude(p => p.Trainer)
                .ToListAsync();
        }
        public async Task<Attendance> GetAttendanceByIdAsync(string id)
        {
            return await _context.Attendances
                .AsSplitQuery() 
                .Include(a => a.Dog) 
                .Include(a => a.ProgressReports)
                    .ThenInclude(p => p.Trainer)
                .FirstOrDefaultAsync(a => a.Id == id); 
        }

    }
}
