using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.Entities;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/dogOwnerships")]
    public class DogOwnershipController : Controller
    {
        private readonly IDogOwnershipsService _ownershipsService;

        public DogOwnershipController(IDogOwnershipsService ownershipsService)
        {
            _ownershipsService = ownershipsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOwnerships()
        {
            var response = await _ownershipsService.GetAllDogOwnerships();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOwnershipById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var result = await _ownershipsService.GetDogOwnershipById(id);
                return Ok(result);
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

        [HttpPost]
        public async Task<IActionResult> CreateDogOwnership([FromBody] CreateDogOwnershipRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _ownershipsService.CreateDogOwnershipAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDogOwnership(string id, [FromBody] UpdateDogOwnershipRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _ownershipsService.UpdateDogOwnershipAsync(id, request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
