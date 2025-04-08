using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.DTOs.Response;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/attendances")]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceService _attendanceService;

        public AttendanceController(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AttendanceResponse>>> GetAllAttendance()
        {
            var attendances = await _attendanceService.GetAllAttendanceAsync();
            return Ok(attendances);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AttendanceResponse>> GetAttendanceById(string id)
        {
            var attendance = await _attendanceService.GetAttendanceByIdAsync(id);

            if (attendance == null)
            {
                return NotFound("Attendance not found.");
            }

            return Ok(attendance);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAttendance([FromBody] CreateAttendanceRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid data.");
            }

            try
            {
                var result = await _attendanceService.CreateAttendanceAsync(request);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAttendance(string id, [FromBody] UpdateAttendanceRequest request)
        {
            try
            {
                var result = await _attendanceService.UpdateAttendanceAsync(id, request);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("checkout/{id}")]
        public async Task<IActionResult> CheckoutAttendance(string id)
        {
            var response = await _attendanceService.CheckoutAttendance(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}
