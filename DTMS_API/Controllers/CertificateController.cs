using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.DTOs.Certificate.Request;
using Models.DTOs.Certificate.Response;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/certificates")]
    public class CertificateController : ControllerBase
    {
        private readonly ICertificateService _certificateService;

        public CertificateController(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCertificates()
        {
            var response = await _certificateService.GetAllCertificates();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CertificateResponse>> GetById(string id)
        {
            try
            {
                var certificate = await _certificateService.GetCertificateById(id);
                return Ok(certificate);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("by-dog/{dogId}")]
        public async Task<ActionResult<List<CertificateResponse>>> GetCertificatesByDogId(string dogId)
        {
            try
            {
                var certificates = await _certificateService.GetCertificatesByDogId(dogId);
                return Ok(certificates);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while processing your request" });
            }
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCertificateRequest request)
        {
            try
            {
                var result = await _certificateService.CreateCertificateAsync(request);
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
        public async Task<IActionResult> Update([FromRoute] string id, [FromBody] UpdateCertificateRequest request)
        {
            try
            {
                if (!request.IsValid())
                    return BadRequest("At least one update field must be provided");

                var result = await _certificateService.UpdateCertificateAsync(id, request);
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
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //public async Task<IActionResult> CreateCertificate(CreateCertificateRequest request)
        //{
        //    return null;
        //}
    }
}
