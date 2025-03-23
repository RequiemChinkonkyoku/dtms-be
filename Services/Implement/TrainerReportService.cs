using AutoMapper;
using Models.DTOs;
using Models.DTOs.Certification;
using Models.DTOs.TrainerReport;
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
    public class TrainerReportService : ITrainerReportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrainerReportService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseResponseDTO<TrainerReportResponse>> GetAllTrainerReports()
        {
            var result = await _unitOfWork.TrainerReports.GetAll();
            var response = _mapper.Map<List<TrainerReportResponse>>(result);
            return new BaseResponseDTO<TrainerReportResponse> { Success = true, ObjectList = response };
        }

        public async Task<BaseResponseDTO<TrainerReportResponse>> GetTrainerReportById(string id)
        {
            var result = await _unitOfWork.TrainerReports.GetById(id);

            if (result == null)
            {
                return new BaseResponseDTO<TrainerReportResponse> { Success = false, Message = "Unable to find trainer report with id " + id };
            }

            var response = _mapper.Map<TrainerReportResponse>(result);
            return new BaseResponseDTO<TrainerReportResponse> { Success = true, Object = response };
        }

        public async Task<BaseResponseDTO<TrainerReportResponse>> CreateTrainerReportAsync(CreateTrainerReportRequest createTrainerReportRequest)
        {
            if (string.IsNullOrWhiteSpace(createTrainerReportRequest.TrainerProfileId) ||
            string.IsNullOrWhiteSpace(createTrainerReportRequest.CustomerProfileId))
            {
                throw new ArgumentException("TrainerProfileId and CustomerProfileId are required.");
            }

            var trainerProfileId = await _unitOfWork.Accounts.GetById(createTrainerReportRequest.TrainerProfileId);
            var customerProfileId = await _unitOfWork.Accounts.GetById(createTrainerReportRequest.CustomerProfileId);

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

            if (customerProfileId == null)
            {
                throw new KeyNotFoundException("CustomerProfileId is not valid.");
            }

            var customerRole = await _unitOfWork.Roles.GetById(customerProfileId.RoleId);
            if (customerRole == null)
            {
                throw new KeyNotFoundException("CustomerProfileId is not valid.");
            }
            if (customerRole.Name != "Customer_Individual" && customerRole.Name != "Customer_Organizational")
            {
                throw new ArgumentException("CustomerProfileId is not a customer.");
            }

            var report = _mapper.Map<TrainerReport>(createTrainerReportRequest);

            report.TrainerId = createTrainerReportRequest.TrainerProfileId;
            report.CustomerId = createTrainerReportRequest.CustomerProfileId;

            await _unitOfWork.TrainerReports.Add(report);
            await _unitOfWork.SaveChanges();

            var response = _mapper.Map<TrainerReportResponse>(report);
            return new BaseResponseDTO<TrainerReportResponse> { Success = true, Object = response };
        }

        public async Task<BaseResponseDTO<TrainerReportResponse>> UpdateTrainerReportAsync(string id, CreateTrainerReportRequest request)
        {
            var existingReport = await _unitOfWork.TrainerReports.GetById(id);

            if (existingReport == null)
            {
                throw new KeyNotFoundException($"Trainer Report not found.");
            }

            if (string.IsNullOrWhiteSpace(request.TrainerProfileId) ||
            string.IsNullOrWhiteSpace(request.CustomerProfileId))
            {
                throw new ArgumentException("TrainerProfileId and CustomerProfileId are required.");
            }

            var trainerProfile = await _unitOfWork.Accounts.GetById(request.TrainerProfileId);
            var customerProfile = await _unitOfWork.Accounts.GetById(request.CustomerProfileId);

            if (trainerProfile == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }

            var trainerRole = await _unitOfWork.Roles.GetById(trainerProfile.RoleId);
            if (trainerRole == null)
            {
                throw new KeyNotFoundException("TrainerProfileId is not valid.");
            }
            if (trainerRole.Name != "Trainer_Member" && trainerRole.Name != "Trainer_Lead")
            {
                throw new ArgumentException("TrainerProfileId is not a trainer.");
            }

            if (customerProfile == null)
            {
                throw new KeyNotFoundException("CustomerProfileId is not valid.");
            }

            var customerRole = await _unitOfWork.Roles.GetById(customerProfile.RoleId);
            if (customerRole == null)
            {
                throw new KeyNotFoundException("CustomerProfileId is not valid.");
            }
            if (customerRole.Name != "Customer_Individual" && customerRole.Name != "Customer_Organizational")
            {
                throw new ArgumentException("CustomerProfileId is not a customer.");
            }

            _mapper.Map(request, existingReport);

            existingReport.LastUpdatedTime = DateTime.UtcNow;
            existingReport.TrainerId = request.TrainerProfileId;
            existingReport.CustomerId = request.CustomerProfileId;

            _unitOfWork.TrainerReports.Update(existingReport);
            await _unitOfWork.SaveChanges();

            var response = _mapper.Map<TrainerReportResponse>(existingReport);
            return new BaseResponseDTO<TrainerReportResponse> { Success = true, Object = response };
        }

        public async Task<bool> DeleteTrainerReportAsync(string id)
        {
            var existingReport = await _unitOfWork.TrainerReports.GetById(id);

            if (existingReport == null)
            {
                throw new KeyNotFoundException($"Trainer Report not found.");
            }

            _unitOfWork.TrainerReports.Delete(existingReport);
            await _unitOfWork.SaveChanges();

            return true;
        }
    }
}
