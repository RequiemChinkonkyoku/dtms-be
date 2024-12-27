using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/dogBreeds")]
    public class DogBreedController : ControllerBase
    {
        private readonly IDogBreedService _dogBreedService;
        public DogBreedController(IDogBreedService dogBreedService)
        {
            _dogBreedService = dogBreedService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBreed()
        {
            var response = await _dogBreedService.GetAllBreed();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDogBreedById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var dogBreed = await _dogBreedService.GetDogBreedByIdAsync(id);
                return Ok(dogBreed);
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
        public async Task<IActionResult> CreateNewBreed(CreateDogBreedRequest request)
        {
            var response = await _dogBreedService.CreateDogBreedAsync(request);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNewBreed([FromBody] UpdateDogBreedRequest request, string id)
        {
            var response = await _dogBreedService.UpdateDogBreedAsync(id, request);
            return Ok(response);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteDogBreed(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");

            try
            {
                var deletedDogBreed = await _dogBreedService.DeleteDogBreedAsync(id);
                return Ok(deletedDogBreed);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
           
        }
    }
}
