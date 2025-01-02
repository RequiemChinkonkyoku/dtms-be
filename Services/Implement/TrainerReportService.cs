using AutoMapper;
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

        public async Task<List<TrainerReportResponse>> GetAllTrainerReports()
        {
            var result = await _unitOfWork.TrainerReports.GetAll();
            return _mapper.Map<List<TrainerReportResponse>>(result);
        }

        public async Task<TrainerReportResponse> GetTrainerReportById(string id)
        {
            var result = await _unitOfWork.TrainerReports.GetById(id);
            return _mapper.Map<TrainerReportResponse>(result);
        }

        public async Task<TrainerReportResponse> CreateTrainerReportAsync(CreateTrainerReportRequest createTrainerReportRequest)
        {
            var report = _mapper.Map<TrainerReport>(createTrainerReportRequest);
            await _unitOfWork.TrainerReports.Add(report);
            await _unitOfWork.SaveChanges();

            return _mapper.Map<TrainerReportResponse>(report);
        }

        public async Task<TrainerReportResponse> UpdateTrainerReportAsync(string id, CreateTrainerReportRequest request)
        {
            var existingReport = await _unitOfWork.TrainerReports.GetById(id);

            if (existingReport == null)
            {
                throw new Exception($"Trainer Report not found.");
            }

            _mapper.Map(request, existingReport);

            existingReport.LastUpdatedTime = DateTime.UtcNow;

            _unitOfWork.TrainerReports.Update(existingReport);
            await _unitOfWork.SaveChanges();

            return _mapper.Map<TrainerReportResponse>(existingReport);
        }

        public async Task<bool> DeleteTrainerReportAsync(string id)
        {
            var existingReport = await _unitOfWork.TrainerReports.GetById(id);

            if (existingReport == null)
            {
                throw new Exception($"Trainer Report not found.");
            }

            _unitOfWork.TrainerReports.Delete(existingReport);
            await _unitOfWork.SaveChanges();

            return true;
        }
    }
}
