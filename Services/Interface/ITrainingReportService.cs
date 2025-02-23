using Models.DTOs;
using Models.DTOs.TrainingReport;

namespace Services.Interface
{
    public interface ITrainingReportService
    {
        Task<BaseResponseDTO<TrainingReportResponse>> GetAllTrainingReports();
        Task<BaseResponseDTO<TrainingReportResponse>> GetTrainingReportById(string id);
        Task<BaseResponseDTO<TrainingReportResponse>> GetTrainingReportsByDogId(string dogId);
        Task<BaseResponseDTO<TrainingReportResponse>> CreateTrainingReportAsync(CreateTrainingReportRequest createTrainingReportRequest);
        Task<BaseResponseDTO<TrainingReportResponse>> UpdateTrainingReportAsync(string id, CreateTrainingReportRequest request);
        Task<bool> DeleteTrainingReportAsync(string id);
    }
}
