using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.DTOs.TrainingReport;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/progressReports")]
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProgressReportById(string id)
        {
            try
            {
                var result = await _progressReportService.GetProgressReportByIdAsync(id);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("slot/{slotId}")]
        public async Task<IActionResult> GetProgressReportsByClassId(string slotId)
        {
            try
            {
                var result = await _progressReportService.GetProgressReportsBySlotIdAsync(slotId);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
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

        [HttpGet("classes/{classId}/dogs/{dogId}")]
        public async Task<IActionResult> GetProgressReportsByClassAndDog(string classId, string dogId)
        {
            if (string.IsNullOrWhiteSpace(classId))
                return BadRequest("ClassId is required.");

            if (string.IsNullOrWhiteSpace(dogId))
                return BadRequest("DogId is required.");

            try
            {
                var progressReports = await _progressReportService.GetProgressReportsByClassAndDog(classId, dogId);
                return Ok(progressReports);
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

