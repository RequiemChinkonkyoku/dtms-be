using Models.DTOs.TrainerReport;
using Models.Entities;

namespace Services.Interface
{
    public interface ITrainerReportService
    {
        Task<List<TrainerReportResponse>> GetAllTrainerReports();
        Task<TrainerReportResponse> GetTrainerReportById(string id);
        Task<TrainerReportResponse> CreateTrainerReportAsync(CreateTrainerReportRequest createTrainerReportRequest);
        Task<TrainerReportResponse> UpdateTrainerReportAsync(string id, CreateTrainerReportRequest request);
        Task<bool> DeleteTrainerReportAsync(string id);
    }
}
