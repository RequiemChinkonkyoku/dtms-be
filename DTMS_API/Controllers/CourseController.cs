using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/courses")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {
            var response = await _courseService.GetAllCourses();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseById(string id)
        {
            var response = await _courseService.GetCourseById(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpGet("get-courses-by-category-id/{categoryId}")]
        public async Task<IActionResult> GetCoursesByCategoryId(string categoryId)
        {
            var response = await _courseService.GetCoursesByCategoryId(categoryId);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(CreateCourseRequest request)
        {
            var response = await _courseService.CreateCourse(request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCourse(UpdateCourseRequest request)
        {
            var response = await _courseService.UpdateCourse(request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(string id)
        {
            var response = await _courseService.DeleteCourse(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response.Message);
            }
        }
    }
}
