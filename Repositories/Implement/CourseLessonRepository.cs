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
    public class CourseLessonRepository : RepositoryBase<CourseLesson>, ICourseLessonRepository
    {
        public async Task<List<CourseLesson>> GetAllCourseLessons()
        {
            return await _context.CourseLessons
                            .AsSplitQuery()
                            .Include(cl => cl.Course)
                            .Include(cl => cl.Lesson)
                            .ToListAsync();
        }

        public async Task<List<CourseLesson>> GetCourseLessonsByCourseId(string courseId)
        {
            return await _context.CourseLessons
                            .AsSplitQuery()
                            .Include(cl => cl.Course)
                            .Include(cl => cl.Lesson)
                            .Where(cl => cl.CourseId == courseId)
                            .ToListAsync();
        }
    }
}
