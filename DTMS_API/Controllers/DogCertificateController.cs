using Microsoft.AspNetCore.Mvc;
using Models.DTOs.DogCertificate.Request;
using Models.DTOs.DogCertificate.Response;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/dogCertificates")]
    public class DogCertificateController : Controller
    {
        private readonly IDogCertificateService _dogCertificateService;

        public DogCertificateController(IDogCertificateService dogCertificateService)
        {
            _dogCertificateService = dogCertificateService;
        }

        [HttpGet]
        public async Task<ActionResult<List<DogCertificateResponse>>> GetAll()
        {
            return Ok(await _dogCertificateService.GetAllDogCertificates());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DogCertificateResponse>> GetById(string id)
        {
            try
            {
                var result = await _dogCertificateService.GetByIdWithDetailAsync(id);
                return Ok(result);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDogCertificateRequest request)
        {
            try
            {
                var result = await _dogCertificateService.CreateDogCertificateAsync(request);
                return Ok(new { Message = result });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] string id, [FromBody] UpdateDogCertificateRequest request)
        {
            try
            {
                var result = await _dogCertificateService
                    .UpdateDogCertificateAsync(id, request);
                return Ok(new { Message = result });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(ex.Message);
            }
        }


    }
}
