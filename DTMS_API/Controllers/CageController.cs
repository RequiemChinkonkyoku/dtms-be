using Azure.Core;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Cage.Request;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/cages")]
    public class CageController : ControllerBase
    {
        private readonly ICageService _cageService;

        public CageController(ICageService cageService)
        {
            _cageService = cageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCages()
        {
            var response = await _cageService.GetAllCages();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCageById(string id)
        {
            var response = await _cageService.GetCageById(id);

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
        public async Task<IActionResult> CreateCage(CreateCageRequest request)
        {
            var response = await _cageService.CreateCage(request);

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
        public async Task<IActionResult> UpdateCage(UpdateCageRequest request)
        {
            var response = await _cageService.UpdateCage(request);

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
        public async Task<IActionResult> DeleteCage(string id)
        {
            var response = await _cageService.DeleteCage(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpGet("get-cage-by-staff-id/{id}")]
        public async Task<IActionResult> GetCageByStaffId(string id)
        {
            var response = await _cageService.GetCageByStaffId(id);

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
