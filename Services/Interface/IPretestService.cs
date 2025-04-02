using Models.DTOs;
using Models.DTOs.Pretest.Request;
using Models.DTOs.Pretest.Response;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IPretestService
    {
        Task<BaseResponseDTO<GetPretestResponse>> GetAllPretest();
        Task<BaseResponseDTO<GetPretestResponse>> GetClassPretests(GetPretestRequest request);
        Task<BaseResponseDTO<GetPretestResponse>> GetPretestById(string id);
        Task<BaseResponseDTO<GetPretestResponse>> UpdatePretestStatus(string id, int pretestStatus);
    }
}
