using Models.DTOs.TrainingReport;

namespace Services.Interface
{
    public interface ITrainingReportService
    {
        Task<List<TrainingReportResponse>> GetAllTrainingReports();
        Task<TrainingReportResponse> GetTrainingReportById(string id);
        Task<List<TrainingReportResponse>> GetTrainingReportsByDogId(string dogId);
        Task<TrainingReportResponse> CreateTrainingReportAsync(CreateTrainingReportRequest createTrainingReportRequest);
        Task<TrainingReportResponse> UpdateTrainingReportAsync(string id, CreateTrainingReportRequest request);
        Task<bool> DeleteTrainingReportAsync(string id);
    }
}
