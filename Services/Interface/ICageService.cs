using Models.DTOs;
using Models.DTOs.Cage.Request;
using Models.DTOs.Cage.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface ICageService
    {
        Task<BaseResponseDTO<Cage>> GetAllCages();
        Task<BaseResponseDTO<Cage>> GetCageById(string id);
        Task<BaseResponseDTO<Cage>> CreateCage(CreateCageRequest request);
        Task<BaseResponseDTO<Cage>> UpdateCage(UpdateCageRequest request);
        Task<BaseResponseDTO<Cage>> DeleteCage(string id);
        Task<BaseResponseDTO<GetStaffCageResponse>> GetCageByStaffId(string id);
    }
}
