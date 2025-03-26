using Models.DTOs;
using Models.DTOs.Class.Request;
using Models.DTOs.Class.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IClassService
    {
        Task<BaseResponseDTO<Class>> CreateClass(CreateClassRequest request);
        Task<BaseResponseDTO<Class>> DeleteClass(string id);
        Task<BaseResponseDTO<Class>> EnrollClass(EnrollClassRequest request);
        Task<BaseResponseDTO<GetClassResponse>> GetAllClasses();
        Task<BaseResponseDTO<Class>> GetClassByCourseId(string id);
        Task<BaseResponseDTO<GetClassResponse>> GetClassById(string id);
        Task<BaseResponseDTO<Class>> GetClassSlots(string id);
        Task<BaseResponseDTO<Class>> GetDogEnrolledClasses(string id);
        Task<BaseResponseDTO<Class>> UpdateClass(UpdateClassRequest request);
    }
}
