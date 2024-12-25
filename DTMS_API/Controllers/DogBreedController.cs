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
    }
}
