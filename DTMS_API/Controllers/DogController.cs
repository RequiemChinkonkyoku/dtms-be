using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/dogs")]
    public class DogController : ControllerBase
    {
        private readonly IDogService _dogService;

        public DogController(IDogService dogService)
        {
            _dogService = dogService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDogs()
        {
            var response = await _dogService.GetAllDogs();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDogById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var dog = await _dogService.GetDogById(id);
                return Ok(dog);
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
        public async Task<IActionResult> CreateNewDog(CreateDogRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var response = await _dogService.CreateDogAsync(request);
                return Ok(response);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNewDog([FromBody] UpdateDogRequest request, string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var response = await _dogService.UpdateDogAsync(id, request);
                return Ok(response);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDog(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest("Dog ID is required.");

            try
            {
                var deletedDog = await _dogService.DeleteDogAsync(id);
                return Ok(deletedDog);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("by-customer/{customerProfileId}")]
        public async Task<IActionResult> GetDogsByCustomerProfileId(string customerProfileId)
        {
            var dogs = await _dogService.GetDogsByCustomerProfileId(customerProfileId);
            return Ok(dogs);
        }
    }
}
