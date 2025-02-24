using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using Models.DTOs;
using Models.DTOs.Certification;
using Models.DTOs.TrainerReport;
using Models.DTOs.TrainingReport;
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
    public class TrainingReportService : ITrainingReportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrainingReportService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseDTO<TrainingReportResponse>> GetAllTrainingReports()
        {
            var result = await _unitOfWork.TrainingReports.GetAll();
            var response = _mapper.Map<List<TrainingReportResponse>>(result);
            return new BaseResponseDTO<TrainingReportResponse> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<TrainingReportResponse>> GetTrainingReportById(string id)
        {
            var result = await _unitOfWork.TrainingReports.GetById(id);

            if (result == null)
            {
                return new BaseResponseDTO<TrainingReportResponse> { Success = false, Message = "Unable to find training report with id " + id };
            }

            var response = _mapper.Map<TrainingReportResponse>(result);
            return new BaseResponseDTO<TrainingReportResponse> { Success = true, Object = response };
        }

        public async Task<BaseResponseDTO<TrainingReportResponse>> GetTrainingReportsByDogId(string dogId)
        {
            var result = await _unitOfWork.TrainingReports.Get(d => d.DogId == dogId);

            if (result.IsNullOrEmpty())
            {
                return new BaseResponseDTO<TrainingReportResponse> { Success = false, Message = "Unable to find training report with dogId " + dogId };
            }

            var response = _mapper.Map<List<TrainingReportResponse>>(result);
            return new BaseResponseDTO<TrainingReportResponse> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<TrainingReportResponse>> CreateTrainingReportAsync(CreateTrainingReportRequest createTrainingReportRequest)
        {
            if (string.IsNullOrWhiteSpace(createTrainingReportRequest.DogId) ||
            string.IsNullOrWhiteSpace(createTrainingReportRequest.TrainerProfileId))
            {
                throw new ArgumentException("DogId and TrainerProfileId are required.");
            }

            var dogId = await _unitOfWork.Dogs.GetById(createTrainingReportRequest.DogId);
            var trainerProfileId = await _unitOfWork.CustomerProfiles.GetById(createTrainingReportRequest.TrainerProfileId);

            if (dogId == null)
            {
                throw new KeyNotFoundException("DogId is not valid.");
            }

            if (trainerProfileId == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }

            var report = _mapper.Map<TrainingReport>(createTrainingReportRequest);
            await _unitOfWork.TrainingReports.Add(report);
            await _unitOfWork.SaveChanges();

            var response = _mapper.Map<TrainingReportResponse>(report);
            return new BaseResponseDTO<TrainingReportResponse> { Success = true, Object = response };
        }

        public async Task<BaseResponseDTO<TrainingReportResponse>> UpdateTrainingReportAsync(string id, CreateTrainingReportRequest request)
        {
            var existingReport = await _unitOfWork.TrainingReports.GetById(id);

            if (existingReport == null)
            {
                throw new KeyNotFoundException($"Training Report not found.");
            }

            if (string.IsNullOrWhiteSpace(request.DogId) ||
            string.IsNullOrWhiteSpace(request.TrainerProfileId))
            {
                throw new ArgumentException("DogId and TrainerProfileId are required.");
            }

            var dogId = await _unitOfWork.Dogs.GetById(request.DogId);
            var trainerProfileId = await _unitOfWork.CustomerProfiles.GetById(request.TrainerProfileId);

            if (dogId == null)
            {
                throw new KeyNotFoundException("DogId is not valid.");
            }

            if (trainerProfileId == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }

            _mapper.Map(request, existingReport);

            existingReport.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.TrainingReports.Update(existingReport);
            await _unitOfWork.SaveChanges();

            var response = _mapper.Map<TrainingReportResponse>(existingReport);
            return new BaseResponseDTO<TrainingReportResponse> { Success = true, Object = response };
        }

        public async Task<bool> DeleteTrainingReportAsync(string id)
        {
            var existingReport = await _unitOfWork.TrainingReports.GetById(id);

            if (existingReport == null)
            {
                throw new KeyNotFoundException($"Training Report not found.");
            }

            _unitOfWork.TrainingReports.Delete(existingReport);
            await _unitOfWork.SaveChanges();

            return true;
        }
    }
}
