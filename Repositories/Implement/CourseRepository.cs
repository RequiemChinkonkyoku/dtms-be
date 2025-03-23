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
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public async Task<Course> GetCourseById(string id)
        {
            return await _context.Courses
                .AsSplitQuery()
                .Include(c => c.Trainer)
                .Include(c => c.Category)
                .Include(c => c.Certificate)
                .Include(c => c.Prerequisites)
                    .ThenInclude(p => p.PrerequisiteCourse)
                .Include(c => c.CourseLessons)
                    .ThenInclude(cl => cl.Lesson)
                .Include(c => c.CourseDogs)
                    .ThenInclude(cd => cd.DogBreed)
                .Include(c => c.Certificate)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Course>> GetCoursesByCategoryId(string categoryId)
        {
            return await _context.Courses
                .AsSplitQuery()
                .Where(c => c.CategoryId == categoryId)
                .ToListAsync();
        }
    }
}
