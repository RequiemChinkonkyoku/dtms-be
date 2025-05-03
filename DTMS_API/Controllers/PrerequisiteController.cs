using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Services.Interface;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Authorization;

namespace DTMS_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/prerequisites")]
    public class PrerequisiteController : ControllerBase
    {
        private readonly IPrerequisiteService _prerequisiteService;

        public PrerequisiteController(IPrerequisiteService prerequisiteService)
        {
            _prerequisiteService = prerequisiteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPrerequisites()
        {
            var response = await _prerequisiteService.GetAllPrerequisites();

            return Ok(response);
        }

        [HttpGet("course/{id}")]
        public async Task<IActionResult> GetPrerequisitesByCourseId(string id)
        {
            var response = await _prerequisiteService.GetPrerequisitesByCourseId(id);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePrerequisite(CreatePrerequisiteRequest request)
        {
            var response = await _prerequisiteService.CreatePrerequisite(request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpPut("course/{id}")]
        public async Task<IActionResult> UpdatePrerequisite(string id, UpdatePrerequisiteRequest request)
        {
            var response = await _prerequisiteService.UpdatePrerequisite(id, request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePrerequisite([FromBody] List<string> ids)
        {
            var response = await _prerequisiteService.DeletePrerequisite(ids);

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
