using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetAllAccounts()
        {
            var response = await _dogBreedService.GetAllBreed();
            return Ok(response);
        }
    }
}
