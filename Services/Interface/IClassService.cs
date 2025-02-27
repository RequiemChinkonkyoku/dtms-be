using Models.DTOs;
using Models.DTOs.Class;
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
        Task<BaseResponseDTO<Class>> GetAllClasses();
        Task<BaseResponseDTO<Class>> GetClassById(string id);
        Task<BaseResponseDTO<Class>> GetClassSlots(string id);
    }
}
