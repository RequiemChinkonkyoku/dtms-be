using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface
{
    public interface ICourseLessonRepository : IRepositoryBase<CourseLesson>
    {
        Task<List<CourseLesson>> GetAllCourseLessons();
        Task<List<CourseLesson>> GetCourseLessonsByCourseId(string courseId);
    }
}
