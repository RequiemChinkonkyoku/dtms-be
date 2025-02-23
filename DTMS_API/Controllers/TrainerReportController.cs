using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.TrainerReport;
using Models.Entities;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Route("api/trainerReport")]
    [ApiController]
    public class TrainerReportController : ControllerBase
    {
        private readonly ITrainerReportService _trainerReportService;

        public TrainerReportController(ITrainerReportService trainerReportService)
        {
            _trainerReportService = trainerReportService;
        }

        [HttpGet("get-all-trainer-reports")]
        public async Task<IActionResult> GetAllTrainerReports()
        {
            var response = await _trainerReportService.GetAllTrainerReports();
            return Ok(response);
        }

        [HttpGet("get-trainer-report-by-id/{id}")]
        public async Task<IActionResult> GetTrainerReportById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var report = await _trainerReportService.GetTrainerReportById(id);
                if (report.Success)
                {
                    return Ok(report);
                }
                else
                {
                    return NotFound(report);
                }
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("create-trainer-report")]
        public async Task<IActionResult> CreateTrainerReport(CreateTrainerReportRequest request)
        {
            try
            {
               var response = await _trainerReportService.CreateTrainerReportAsync(request);
               return Ok(response);
            }
            catch (ArgumentException ex)
            {
               return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
               return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
               return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("update-trainer-report/{id}")]
        public async Task<IActionResult> UpdateTrainerReport(string id, [FromBody] CreateTrainerReportRequest request)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Invalid id.");

            try
            {
                var response = await _trainerReportService.UpdateTrainerReportAsync(id, request);
                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("delete-trainer-report/{id}")]
        public async Task<IActionResult> DeleteTrainerReport(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Invalid id.");

            try
            {
                var success = await _trainerReportService.DeleteTrainerReportAsync(id);
                if (!success)
                    return NotFound("Trainer Report not found!");
                return Ok("Trainer Report deleted successfully.");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
