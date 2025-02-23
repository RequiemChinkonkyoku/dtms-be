using Microsoft.AspNetCore.Mvc;
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
    }
}
