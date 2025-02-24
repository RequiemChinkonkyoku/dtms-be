using Models.DTOs;
using Models.DTOs.Course;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ICourseService
    {
        Task<BaseResponseDTO<Course>> CreateCourse(CreateCourseRequest request);
        Task<BaseResponseDTO<Course>> DeleteCourse(string id);
        Task<BaseResponseDTO<Course>> GetAllCourses();
        Task<BaseResponseDTO<Course>> GetCoursesByCategoryId(string categoryId);
        Task<BaseResponseDTO<CourseResponse>> GetCourseById(string id);
        Task<BaseResponseDTO<Course>> UpdateCourse(UpdateCourseRequest request);
    }
}
