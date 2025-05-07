using AutoMapper;
using Azure;
using Microsoft.IdentityModel.Tokens;
using Models.Constants;
using Models.DTOs;
using Models.DTOs.Pretest.Request;
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

        public async Task<BaseResponseDTO<GetPretestResponse>> GetClassPretests(GetPretestRequest request)
        {
            var classPretest = new List<PreTest>();

            if (request.DogId.IsNullOrEmpty() ||
                string.Equals(request.DogId, "string", StringComparison.OrdinalIgnoreCase))
            {
                classPretest = (await _unitOfWork.Pretests.GetAllPretestsAsync())
                                            .Where(p => p.ClassId == request.ClassId)
                                            .OrderBy(p => p.TestDate)
                                            .ToList();
            }
            else
            {
                classPretest = (await _unitOfWork.Pretests.GetAllPretestsAsync())
                                            .Where(p => p.ClassId == request.ClassId && p.DogId == request.DogId)
                                            .OrderBy(p => p.TestDate)
                                            .ToList();
            }

            if (classPretest.IsNullOrEmpty())
            {
                return new BaseResponseDTO<GetPretestResponse>
                {
                    Success = false,
                    Message = "There are no pretest for the class " + request.ClassId
                };
            }

            var mappedResponse = _mapper.Map<List<GetPretestResponse>>(classPretest);

            return new BaseResponseDTO<GetPretestResponse> { Success = true, ObjectList = mappedResponse };
        }

        public async Task<BaseResponseDTO<GetPretestResponse>> UpdatePretest(string id, UpdatePretestRequest request)
        {
            if (!Enum.IsDefined(typeof(PretestStatusEnum), request.Status))
            {
                return new BaseResponseDTO<GetPretestResponse> { Success = false, Message = "Invalid pretestStatus value " + request.Status };
            }

            var pretest = await _unitOfWork.Pretests.GetPretestByIdAsync(id);

            if (pretest == null)
            {
                return new BaseResponseDTO<GetPretestResponse> { Success = false, Message = "Unable to find pretest with id " + id };
            }

            if (pretest.TestDate != DateOnly.FromDateTime(DateTime.UtcNow))
            {
                return new BaseResponseDTO<GetPretestResponse> { Success = false, Message = $"Today is not the test date." };
            }

            pretest.Status = request.Status;

            try
            {
                if (pretest.Status == (int)PretestStatusEnum.Rejected)
                {
                    var enrollment = await _unitOfWork.Enrollments.GetEnrollmentByDogAndClass(pretest.DogId, pretest.ClassId);

                    if (enrollment == null)
                    {
                        return new BaseResponseDTO<GetPretestResponse> { Success = false, Message = "Unable to find the matching enrollment." };
                    }

                    enrollment.Status = (int)EnrollmentStatusEnum.Inactive;

                    if (enrollment.RequiredNightStay)
                    {
                        var cage = await _unitOfWork.Cages.GetCageById(enrollment.CageId);

                        if (cage == null)
                        {
                            return new BaseResponseDTO<GetPretestResponse> { Success = false, Message = "Unable to find cage." };
                        }

                        cage.Status = (int)CageStatusEnum.Available;

                        await _unitOfWork.Cages.Update(cage);
                    }

                    var existingClass = await _unitOfWork.Classes.GetById(enrollment.ClassId);

                    if (existingClass == null)
                    {
                        return new BaseResponseDTO<GetPretestResponse>
                        {
                            Success = false,
                            Message = $"Unable to find class with id ${enrollment.ClassId}."
                        };
                    }

                    existingClass.EnrolledDogCount -= 1;
                    await _unitOfWork.Classes.Update(existingClass);

                    await _unitOfWork.Enrollments.Update(enrollment);
                }

                pretest.Note = !(request.Note).IsNullOrEmpty() ? request.Note : "None";

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
                    Message = "There has been an error. Ex: " + ex.Message
                };
            }
        }
    }
}
