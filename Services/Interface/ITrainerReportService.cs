using Models.DTOs;
using Models.DTOs.TrainerReport;
using Models.Entities;

namespace Services.Interface
{
    public interface ITrainerReportService
    {
        Task<BaseResponseDTO<TrainerReportResponse>> GetAllTrainerReports();
        Task<BaseResponseDTO<TrainerReportResponse>> GetTrainerReportById(string id);
        Task<BaseResponseDTO<TrainerReportResponse>> CreateTrainerReportAsync(CreateTrainerReportRequest createTrainerReportRequest);
        Task<BaseResponseDTO<TrainerReportResponse>> UpdateTrainerReportAsync(string id, CreateTrainerReportRequest request);
        Task<bool> DeleteTrainerReportAsync(string id);
    }
}
