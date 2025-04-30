using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.TrainingReport;
using Models.Entities;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Authorize]
    [Route("api/trainingReport")]
    [ApiController]
    public class TrainingReportController : ControllerBase
    {
        private readonly ITrainingReportService _trainingReportService;

        public TrainingReportController(ITrainingReportService trainingReportService)
        {
            _trainingReportService = trainingReportService;
        }

        [HttpGet("get-all-training-reports")]
        public async Task<IActionResult> GetAllTrainingReports()
        {
            var response = await _trainingReportService.GetAllTrainingReports();
            return Ok(response);
        }

        [HttpGet("get-training-report-by-id/{id}")]
        public async Task<IActionResult> GetTrainingReportById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var report = await _trainingReportService.GetTrainingReportById(id);
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

        [HttpGet("get-training-reports-by-dog-id/{dogId}")]
        public async Task<IActionResult> GetTrainingReportsByDogId(string dogId)
        {
            if (string.IsNullOrWhiteSpace(dogId))
                return BadRequest("Dog ID is required.");
            try
            {
                var reports = await _trainingReportService.GetTrainingReportsByDogId(dogId);
                if (reports.Success)
                {
                    return Ok(reports);
                }
                else
                {
                    return NotFound(reports);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("create-training-report")]
        public async Task<IActionResult> CreateTrainingReport(CreateTrainingReportRequest request)
        {
            try
            {
                var response = await _trainingReportService.CreateTrainingReportAsync(request);
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

        [HttpPut("update-training-report/{id}")]
        public async Task<IActionResult> UpdateTrainingReport(string id, [FromBody] CreateTrainingReportRequest request)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Invalid id.");

            try
            {
                var response = await _trainingReportService.UpdateTrainingReportAsync(id, request);
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

        [HttpDelete("delete-training-report/{id}")]
        public async Task<IActionResult> DeleteTrainingReport(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Invalid id.");

            try
            {
                var success = await _trainingReportService.DeleteTrainingReportAsync(id);
                if (!success)
                    return NotFound("Training Report not found!");
                return Ok("Training Report deleted successfully.");
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
    }
}
