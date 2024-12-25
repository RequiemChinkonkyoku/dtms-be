using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace DTMS_API.Controllers
{
    public class DogController : Controller
    {
        private readonly IDogService _dogService;

        [HttpGet]
        public async Task<IActionResult> GetAllDogs()
        {
            var response = await _dogService.GetAllDogs();
            return Ok(response);
        }
    }
}
