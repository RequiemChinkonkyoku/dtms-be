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
    }
}
