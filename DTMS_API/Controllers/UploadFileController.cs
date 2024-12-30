using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/uploadFile")]
    public class UploadFileController : ControllerBase
    {
        private readonly ICloudinaryService _cloudinaryService;

        public UploadFileController(ICloudinaryService cloudinaryService)
        {
            _cloudinaryService = cloudinaryService;
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            try
            {
                var result = await _cloudinaryService.UploadFile(file);
                return Ok(result);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
