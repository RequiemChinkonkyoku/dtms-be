using Models.DTOs;
using Models.DTOs.Response;
using Models.DTOs.TrainingReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IProgressReportService
    {
      Task<string> CreateProgressReportAsync(CreateProgressReportRequest request);
      Task<List<ProgressReportResponse>> GetAllProgressReport();
      Task<string> UpdateProgressReportAsync(string progressReportId, UpdateProgressReportRequest request);
      Task<ProgressReportResponse> GetProgressReportByIdAsync(string progressReportId);
      Task<List<ProgressReportResponse>> GetProgressReportsBySlotIdAsync(string slotId);
      Task<List<GetProgressReportByClassResponse>> GetProgressReportsByClassAndDog(string classId, string dogId);
    }
}
