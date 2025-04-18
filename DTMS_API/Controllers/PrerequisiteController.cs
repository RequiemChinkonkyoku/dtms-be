﻿using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Services.Interface;
using System.Runtime.InteropServices;

namespace DTMS_API.Controllers
{
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCoursePrerequisites(string id)
        {
            var response = await _prerequisiteService.GetCoursePrerequisites(id);

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
                return BadRequest(response.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePrerequisite(UpdatePrerequisiteRequest request)
        {
            var response = await _prerequisiteService.UpdatePrerequisite(request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response.Message);
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
                return BadRequest(response.Message);
            }
        }
    }
}
