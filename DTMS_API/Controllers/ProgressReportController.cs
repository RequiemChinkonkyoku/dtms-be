using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.DTOs.TrainingReport;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/progress-reports")]
    public class ProgressReportController : Controller
    {
        private readonly IProgressReportService _progressReportService;

        public ProgressReportController(IProgressReportService progressReportService)
        {
            _progressReportService = progressReportService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReport()
        {
            var response = await _progressReportService.GetAllProgressReport();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProgressReportRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request.");
            }

            try
            {
                var message = await _progressReportService.CreateProgressReportAsync(request);
                return Ok(new { message });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the Progress Report.", details = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProgressReport(string id, [FromBody] UpdateProgressReportRequest request)
        {
            try
            {
                var result = await _progressReportService.UpdateProgressReportAsync(id, request);

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
