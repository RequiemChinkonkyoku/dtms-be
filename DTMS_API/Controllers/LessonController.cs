using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Services.Interface;
using System.Runtime.CompilerServices;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/lessons")]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLessons()
        {
            var response = await _lessonService.GetAllLessons();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLessonById(string id)
        {
            var response = await _lessonService.GetLessonById(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateLesson(CreateLessonRequest request)
        {
            var response = await _lessonService.CreateLesson(request);

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
        public async Task<IActionResult> UpdateLesson(UpdateLessonRequest request)
        {
            var response = await _lessonService.UpdateLesson(request);

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
        public async Task<IActionResult> DeleteLesson(string id)
        {
            var response = await _lessonService.DeleteLesson(id);

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
