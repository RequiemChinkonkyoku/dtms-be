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
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
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
            var enrollments = (await _unitOfWork.Enrollments.GetAll())
                                            .Where(e => e.DogId == dogId)
                                            .Select(e => e.Id)
                                            .ToList();

            if (enrollments.IsNullOrEmpty())
            {
                return new BaseResponseDTO<TrainingReportResponse>
                {
                    Success = false,
                    Message = "Unable to find enrollment with dogId " + dogId
                };
            }

            //var result = await _unitOfWork.TrainingReports.Get(d => d.DogId == dogId);

            var result = new List<TrainingReport>();

            foreach (var enrollment in enrollments)
            {
                var report = (await _unitOfWork.TrainingReports.GetAll())
                                        .Where(tr => tr.EnrollmentId == enrollment)
                                        .ToList();

                if (report.IsNullOrEmpty())
                {
                    return new BaseResponseDTO<TrainingReportResponse>
                    {
                        Success = false,
                        Message = "Unable to find training report with enrollmentId " + enrollment
                    };
                }

                result.AddRange(report);
            }

            if (result.IsNullOrEmpty())
            {
                return new BaseResponseDTO<TrainingReportResponse> { Success = false, Message = "Unable to find training report with dogId " + dogId };
            }

            var response = _mapper.Map<List<TrainingReportResponse>>(result);
            return new BaseResponseDTO<TrainingReportResponse> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<TrainingReportResponse>> CreateTrainingReportAsync(CreateTrainingReportRequest createTrainingReportRequest)
        {
            if (string.IsNullOrWhiteSpace(createTrainingReportRequest.EnrollmentId) ||
            string.IsNullOrWhiteSpace(createTrainingReportRequest.TrainerProfileId))
            {
                throw new ArgumentException("DogId and TrainerProfileId are required.");
            }

            var enrollmentId = await _unitOfWork.Enrollments.GetById(createTrainingReportRequest.EnrollmentId);
            var trainerProfileId = await _unitOfWork.Accounts.GetById(createTrainingReportRequest.TrainerProfileId);

            if (enrollmentId == null)
            {
                throw new KeyNotFoundException("EnrollmentId is not valid.");
            }

            if (trainerProfileId == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }

            var trainerRole = await _unitOfWork.Roles.GetById(trainerProfileId.RoleId);
            if (trainerRole == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }
            if (trainerRole.Name != "Trainer_Member" && trainerRole.Name != "Trainer_Lead")
            {
                throw new ArgumentException("TrainerProfileId is not a trainer.");
            }

            var report = _mapper.Map<TrainingReport>(createTrainingReportRequest);

            report.TrainerId = createTrainingReportRequest.TrainerProfileId;

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

            if (string.IsNullOrWhiteSpace(request.EnrollmentId) ||
            string.IsNullOrWhiteSpace(request.TrainerProfileId))
            {
                throw new ArgumentException("EnrollmentId and TrainerProfileId are required.");
            }

            var enrollmentId = await _unitOfWork.Enrollments.GetById(request.EnrollmentId);
            var trainerProfileId = await _unitOfWork.Accounts.GetById(request.TrainerProfileId);

            if (enrollmentId == null)
            {
                throw new KeyNotFoundException("EnrollmentId is not valid.");
            }

            if (trainerProfileId == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }

            var trainerRole = await _unitOfWork.Roles.GetById(trainerProfileId.RoleId);
            if (trainerRole == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }
            if (trainerRole.Name != "Trainer_Member" && trainerRole.Name != "Trainer_Lead")
            {
                throw new ArgumentException("TrainerProfileId is not a trainer.");
            }

            _mapper.Map(request, existingReport);

            existingReport.LastUpdatedTime = DateTime.UtcNow;
            existingReport.TrainerId = request.TrainerProfileId;

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
