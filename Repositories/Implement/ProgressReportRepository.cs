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
    public class ProgressReportRepository : RepositoryBase<ProgressReport>, IProgressReportRepository
    {
        public async Task<List<ProgressReport>> GetAllProgressReport()
        {
            return await _context.ProgressReports
                .AsSplitQuery()
                .Include(pr => pr.Attendance)
                .Include(pr => pr.Trainer)
                .ToListAsync();
        }

        public async Task<ProgressReport> GetProgressReportById(string progressReportId)
        {
            return await _context.ProgressReports
                .AsSplitQuery()
                .Include(pr => pr.Attendance)
                .Include(pr => pr.Trainer)
                .FirstOrDefaultAsync(pr => pr.Id == progressReportId);
        }

        public async Task<List<ProgressReport>> GetProgressReportsBySlotId(string slotId)
        {
            return await _context.ProgressReports
                .AsSplitQuery()
                .Include(pr => pr.Attendance)
                .Include(pr => pr.Trainer)
                .Where(pr => pr.Attendance.SlotId == slotId)
                .ToListAsync();
        }
    }
}
