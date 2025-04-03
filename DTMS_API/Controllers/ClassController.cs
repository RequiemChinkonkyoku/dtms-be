using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Models.DTOs;
using Models.DTOs.Class.Request;
using Repositories.Migrations;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/class")]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _classService;

        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClass()
        {
            var response = await _classService.GetAllClasses();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClassById(string id)
        {
            var response = await _classService.GetClassById(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpGet("get-classes-by-course-id/{id}")]
        public async Task<IActionResult> GetClassByCourseId(string id)
        {
            var response = await _classService.GetClassByCourseId(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpGet("get-class-slots/{id}")]
        public async Task<IActionResult> GetClassSlots(string id)
        {
            var response = await _classService.GetClassSlots(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateClass(CreateClassRequest request)
        {
            var response = await _classService.CreateClass(request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpPost("enroll-class")]
        public async Task<IActionResult> EnrollClass(EnrollClassRequest request)
        {
            var response = await _classService.EnrollClass(request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateClass(UpdateClassRequest request)
        {
            var response = await _classService.UpdateClass(request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass(string id)
        {
            var response = await _classService.DeleteClass(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpGet("get-dog-enrolled-classes/{id}")]
        public async Task<IActionResult> GetDogEnrolledClasses(string id)
        {
            var response = await _classService.GetDogEnrolledClasses(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpPut("update-class-status")]
        public async Task<IActionResult> UpdateClassStatus(UpdateClassStatusRequest request)
        {
            var response = await _classService.UpdateClassStatus(request);

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
