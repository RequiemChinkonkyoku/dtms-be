using Models.DTOs;
using Models.DTOs.Enrollment.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IEnrollmentService
    {
        Task<BaseResponseDTO<GetEnrollmentResponse>> GetAllEnrollments();
        Task<BaseResponseDTO<GetEnrollmentResponse>> GetAllEnrollmentById(string id);
        Task<BaseResponseDTO<GetEnrollmentResponse>> CancelEnrollment(string id);
        Task<bool> HasCompletedCourse(string dogId, string courseId);
    }
}
