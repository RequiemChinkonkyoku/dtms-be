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
    public class LessonRepository : RepositoryBase<Lesson>, ILessonRepository
    {
        public async Task<List<Lesson>> GetAllLessons()
        {
            return await _context.Lessons
                    .AsSplitQuery()
                    .Include(l => l.Skill)
                    .Include(l => l.LessonEquipments)
                        .ThenInclude(le => le.Equipment)
                    .Include(l => l.CourseLessons)
                        .ThenInclude(cl => cl.Course)
                    .Include(l => l.LessonPrerequisites)
                        .ThenInclude(lp => lp.PrerequisiteLesson)
                    .ToListAsync();
        }

        public async Task<Lesson> GetLessonByIdAsync(string id)
        {
            return await _context.Lessons
                    .AsSplitQuery()
                    .Include(l => l.Skill)
                    .Include(l => l.LessonEquipments)
                        .ThenInclude(le => le.Equipment)
                    .Include(l => l.CourseLessons)
                        .ThenInclude(cl => cl.Course)
                    .Include(l => l.LessonPrerequisites)
                        .ThenInclude(lp => lp.PrerequisiteLesson)
                    .FirstOrDefaultAsync(l => l.Id == id);
        }
    }
}
