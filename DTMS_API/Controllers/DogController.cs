using Microsoft.AspNetCore.Mvc;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/dogs")]
    public class DogController : Controller
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
                var dogBreed = await _dogService.GetDogById(id);
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
    }
}
