using AutoMapper;
using Azure;
using Microsoft.IdentityModel.Tokens;
using Models.Constants;
using Models.DTOs;
using Models.DTOs.Pretest.Response;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implement
{
    public class PretestService : IPretestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PretestService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseDTO<GetPretestResponse>> GetAllPretest()
        {
            var response = (await _unitOfWork.Pretests.GetAllPretestsAsync()).OrderBy(p => p.TestDate);

            var mappedResponse = _mapper.Map<List<GetPretestResponse>>(response);

            return new BaseResponseDTO<GetPretestResponse> { Success = true, ObjectList = mappedResponse };
        }

        public async Task<BaseResponseDTO<GetPretestResponse>> GetPretestById(string id)
        {
            var pretest = await _unitOfWork.Pretests.GetPretestByIdAsync(id);

            if (pretest == null)
            {
                return new BaseResponseDTO<GetPretestResponse> { Success = false, Message = "Unable to find pretest with id " + id };

            }

            var mappedResponse = _mapper.Map<GetPretestResponse>(pretest);

            return new BaseResponseDTO<GetPretestResponse> { Success = true, Object = mappedResponse };
        }

        public async Task<BaseResponseDTO<GetPretestResponse>> GetClassPretests(string id)
        {
            var classPretest = (await _unitOfWork.Pretests.GetAllPretestsAsync())
                                           .Where(p => p.ClassId == id)
                                           .OrderBy(p => p.TestDate)
                                           .ToList();

            if (classPretest.IsNullOrEmpty())
            {
                return new BaseResponseDTO<GetPretestResponse>
                {
                    Success = false,
                    Message = "There are no pretest for the class " + id
                };
            }

            var mappedResponse = _mapper.Map<List<GetPretestResponse>>(classPretest);

            return new BaseResponseDTO<GetPretestResponse> { Success = true, ObjectList = mappedResponse };
        }

        public async Task<BaseResponseDTO<GetPretestResponse>> UpdatePretestStatus(string id, int pretestStatus)
        {
            if (!Enum.IsDefined(typeof(PretestStatusEnum), pretestStatus))
            {
                return new BaseResponseDTO<GetPretestResponse> { Success = false, Message = "Invalid pretestStatus value " + pretestStatus };
            }

            var pretest = await _unitOfWork.Pretests.GetPretestByIdAsync(id);

            if (pretest == null)
            {
                return new BaseResponseDTO<GetPretestResponse> { Success = false, Message = "Unable to find pretest with id " + id };
            }

            pretest.Status = pretestStatus;

            try
            {
                await _unitOfWork.Pretests.Update(pretest);
                await _unitOfWork.SaveChanges();

                var mappedResponse = _mapper.Map<GetPretestResponse>(pretest);

                return new BaseResponseDTO<GetPretestResponse> { Success = true, Object = mappedResponse };
            }
            catch (Exception ex)
            {
                return new BaseResponseDTO<GetPretestResponse>
                {
                    Success = false,
                    Message = "There has been an error updating pretest. Ex: " + ex.Message
                };
            }
        }
    }
}
