using Microsoft.EntityFrameworkCore;
using Models.Constants;
using Models.DTOs.Slot.Response;
using Models.Entities;
using Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.DTOs.Class.Request.CreateClassRequest;

namespace Repositories.Implement
{
    public class SlotRepository : RepositoryBase<Slot>, ISlotRepository
    {
        public async Task<List<GetSlotByClassResponse>> GetSlotsByClassAndDog(string classId, string dogId)
        {
            return await _context.Slots
                .AsSplitQuery()
                .Include(s => s.Schedule)
                .Include(s => s.Lesson)
                .Include(s => s.Attendances)
                .Where(s => s.ClassId == classId &&
                           s.Attendances.Any(a => a.DogId == dogId))
                .OrderBy(s => s.Date)
                .Select(s => new GetSlotByClassResponse
                {
                    Id = s.Id,
                    Date = s.Date,
                    Schedule = new ClassScheduleResponse
                    {
                        StartTime = s.Schedule.StartTime,
                        EndTime = s.Schedule.EndTime
                    },
                    Lesson = s.Lesson != null ? new ClassLessonResponse
                    {
                        Id = s.Lesson.Id,
                        Name = s.Lesson.LessonTitle
                    } : null,
                    Attendance = s.Attendances
                        .FirstOrDefault(a => a.DogId == dogId) != null
                        ? new ClassAttendanceResponse
                        {
                            Id = s.Attendances.First(a => a.DogId == dogId).Id,
                            Date = s.Attendances.First(a => a.DogId == dogId).Date.ToDateTime(TimeOnly.MinValue),
                            DogId = dogId
                        }
                        : null
                })
                .ToListAsync();
        }

        public async Task<List<Slot>> GetClassSlots(string classId)
        {
            return await _context.Slots
                            .AsSplitQuery()
                            .Include(s => s.Class)
                            .Include(s => s.Schedule)
                            .Include(s => s.Lesson)
                            .Where(s => s.ClassId == classId)
                            .ToListAsync();
        }

        public async Task<Slot> GetSlotByIdAsync(string id)
        {
            return await _context.Slots
                            .AsSplitQuery()
                            .Include(s => s.Class)
                            .Include(s => s.Schedule)
                            .Include(s => s.Lesson)
                            .Include(s => s.Attendances)
                            .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<Slot>> GetSlotsByDogAndDate(string dogId, DateOnly date)
        {
            var enrolledClassIds = await _context.Enrollments
                                            .AsSplitQuery()
                                            .Where(e => e.DogId == dogId &&
                                                        e.Status == (int)EnrollmentStatusEnum.Active)
                                            .Select(e => e.ClassId)
                                            .ToListAsync();

            var slots = await _context.Slots
                                .AsSplitQuery()
                                .Include(s => s.Schedule)
                                .Where(s => s.Date == date && enrolledClassIds.Contains(s.ClassId))
                                .ToListAsync();

            return slots;
        }
    }
}
