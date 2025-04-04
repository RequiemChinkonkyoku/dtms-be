using Microsoft.EntityFrameworkCore;
using Models.DTOs.Response;
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

        public async Task<List<GetProgressReportByClassResponse>> GetByClassAndDog(string classId, string dogId)
        {
            return await _context.ProgressReports
                .AsSplitQuery()
                .Include(pr => pr.Attendance)
                    .ThenInclude(a => a.Slot)
                        .ThenInclude(s => s.Schedule)
                .Include(pr => pr.Attendance)
                    .ThenInclude(a => a.Slot)
                        .ThenInclude(s => s.Lesson)
                .Where(pr => pr.Attendance.Slot.ClassId == classId &&
                             pr.Attendance.DogId == dogId)
                .OrderBy(pr => pr.Attendance.Slot.Date)
                .Select(pr => new GetProgressReportByClassResponse
                {
                    Id = pr.Id,
                    Date = pr.Attendance.Slot.Date,
                    Schedule = new ClassScheduleResponse
                    {
                        StartTime = pr.Attendance.Slot.Schedule.StartTime,
                        EndTime = pr.Attendance.Slot.Schedule.EndTime
                    },
                    Lesson = pr.Attendance.Slot.Lesson != null ? new ClassLessonResponse
                    {
                        Id = pr.Attendance.Slot.Lesson.Id,
                        Name = pr.Attendance.Slot.Lesson.LessonTitle
                    } : null,
                    Attendance = new ClassAttendanceResponse
                    {
                        Id = pr.Attendance.Id,
                        Date = pr.Attendance.Date.ToDateTime(TimeOnly.MinValue),
                        DogId = pr.Attendance.DogId
                    },
                })
                .ToListAsync();
        }

    }
}
