using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.DTOs.Response;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Authorize]
    [Route("api/schedules")]
    [ApiController]

    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ScheduleResponse>>> GetAllSchedules()
        {
            var schedules = await _scheduleService.GetAllSchedulesAsync();
            return Ok(schedules);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleResponse>> GetScheduleById(string id)
        {
            var schedule = await _scheduleService.GetScheduleByIdAsync(id);
            if (schedule == null)
                return NotFound($"Schedule with ID {id} not found.");

            return Ok(schedule);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSchedule([FromBody] CreateScheduleRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid schedule data.");
            }

            try
            {
                string result = await _scheduleService.CreateScheduleAsync(request);
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

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSchedule([FromBody] UpdateScheduleRequest request, string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var response = await _scheduleService.UpdateScheduleAsync(id, request);
                return Ok(response);
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

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteSchedule(string id)
        //{
        //    if (string.IsNullOrEmpty(id))
        //        return BadRequest("Scheudle ID is required.");

        //    try
        //    {
        //        var deletedDog = await _scheduleService.DeleteScheduleAsync(id);
        //        return Ok(deletedDog);
        //    }
        //    catch (KeyNotFoundException ex)
        //    {
        //        return NotFound(ex.Message);
        //    }
        //}
    }
}
