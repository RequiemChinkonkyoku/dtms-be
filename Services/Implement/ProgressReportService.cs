using AutoMapper;
using Models.DTOs;
using Models.DTOs.Response;
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
    public class ProgressReportService : IProgressReportService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProgressReportService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ProgressReportResponse>> GetAllProgressReport()
        {
            var result = await _unitOfWork.ProgressReports.GetAllProgressReport();
            return _mapper.Map<List<ProgressReportResponse>>(result);

        }

        public async Task<string> CreateProgressReportAsync(CreateProgressReportRequest request)
        {
            var attendance = await _unitOfWork.Attendances.GetById(request.AttendanceId);
            if (attendance == null)
            {
                throw new ArgumentException($"Attendance with ID {request.AttendanceId} not found.");
            }

            var trainer = await _unitOfWork.Accounts.GetById(request.TrainerId);
            if (trainer == null)
            {
                throw new ArgumentException($"Trainer with ID {request.TrainerId} not found.");
            }

            var newProgressReport = new ProgressReport
            {
                Id = Guid.NewGuid().ToString(),
                Feedback = request.Feedback,
                HealthObservation = request.HealthObservation,
                BehaviorObservation = request.BehaviorObservation,
                PerformanceObservation = request.PerformanceObservation,
                Status = request.Status,
                AttendanceId = request.AttendanceId,
                TrainerId = request.TrainerId,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow
            };

            await _unitOfWork.ProgressReports.Add(newProgressReport);
            await _unitOfWork.SaveChanges();

            return "Progress Report created successfully.";
        }
        public async Task<string> UpdateProgressReportAsync(string progressReportId, UpdateProgressReportRequest request)
        {
            var existingReport = await _unitOfWork.ProgressReports.GetById(progressReportId);
            if (existingReport == null)
            {
                throw new ArgumentException($"Progress report with ID {progressReportId} not found.");
            }

            var attendance = await _unitOfWork.Attendances.GetById(request.AttendanceId);
            if (attendance == null)
            {
                throw new ArgumentException($"Attendance with ID {request.AttendanceId} not found.");
            }

            var trainer = await _unitOfWork.Accounts.GetById(request.TrainerId);
            if (trainer == null)
            {
                throw new ArgumentException($"Trainer with ID {request.TrainerId} not found.");
            }

            existingReport.Feedback = request.Feedback ?? existingReport.Feedback;
            existingReport.HealthObservation = request.HealthObservation ?? existingReport.HealthObservation;
            existingReport.BehaviorObservation = request.BehaviorObservation ?? existingReport.BehaviorObservation;
            existingReport.PerformanceObservation = request.PerformanceObservation ?? existingReport.PerformanceObservation;

            existingReport.Status = request.Status != default ? request.Status : existingReport.Status;

            if (!string.IsNullOrEmpty(request.TrainerId))
            {
                existingReport.TrainerId = request.TrainerId;
            }

            if (!string.IsNullOrEmpty(request.AttendanceId))
            {
                existingReport.AttendanceId = request.AttendanceId;
            }

            existingReport.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.ProgressReports.Update(existingReport);
            await _unitOfWork.SaveChanges();

            return "Progress Report updated successfully.";
        }


    }
}
