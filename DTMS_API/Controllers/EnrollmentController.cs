using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/enrollments")]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;

        public EnrollmentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEnrollments()
        {
            var response = await _enrollmentService.GetAllEnrollments();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllEnrollmentById(string id)
        {
            var response = await _enrollmentService.GetAllEnrollmentById(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpGet("{dogId}/first-enroll/{courseId}")]
        public async Task<IActionResult> CheckFirstEnrollment(string dogId, string courseId)
        {
            var response = await _enrollmentService.CheckFirstEnrollment(dogId, courseId);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> CancelEnrollment(string id)
        {
            var response = await _enrollmentService.CancelEnrollment(id);

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
