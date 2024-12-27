using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
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

        //public async Task<IActionResult> CreateCertificate(CreateCertificateRequest request)
        //{
        //    return null;
        //}
    }
}
