using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/dogBreeds")]
    public class DogBreedController : Controller
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

        [HttpPut("delete/{id}")]
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
