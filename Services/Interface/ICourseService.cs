using Models.DTOs;
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
        Task<BaseResponseDTO<Course>> GetAllCourses();
        Task<BaseResponseDTO<Course>> UpdateCourse(UpdateCourseRequest request);
    }
}
