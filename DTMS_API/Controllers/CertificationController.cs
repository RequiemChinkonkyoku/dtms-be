using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Certification;
using Models.Entities;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Authorize]
    [Route("api/certification")]
    [ApiController]
    public class CertificationController : ControllerBase
    {
        private readonly ICertificationService _certificationService;

        public CertificationController(ICertificationService certificationService)
        {
            _certificationService = certificationService;
        }

        [HttpGet("get-all-certifications")]
        public async Task<IActionResult> GetAllCertifications()
        {
            var response = await _certificationService.GetAllCertifications();
            return Ok(response);
        }

        [HttpGet("get-certifications-by-id/{id}")]
        public async Task<IActionResult> GetCertificationsById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var certification = await _certificationService.GetCertificationsById(id);
                if (certification.Success)
                {
                    return Ok(certification);
                }
                else
                {
                    return NotFound(certification);
                }
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

        [HttpGet("get-certifications-by-name/{name}")]
        public async Task<IActionResult> GetCertificationsByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return BadRequest("Name is required.");
            try
            {
                var certification = await _certificationService.GetCertificationsByName(name);
                if (certification.Success)
                {
                    return Ok(certification);
                }
                else
                {
                    return NotFound(certification);
                }
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

        [HttpPost("create-certifications")]
        public async Task<IActionResult> CreateCertifications(CreateCertificationRequest request)
        {
            try
            {
                var response = await _certificationService.CreateCertificationsAsync(request);
                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
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

        [HttpPut("update-certifications/{id}")]
        public async Task<IActionResult> UpdateCertifications(string id, CreateCertificationRequest request)
        {
            try
            {
                var response = await _certificationService.UpdateCertificationsAsync(id, request);
                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
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

        [HttpDelete("delete-certifications/{id}")]
        public async Task<IActionResult> DeleteCertifications(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var response = await _certificationService.DeleteCertificationsAsync(id);
                if (!response)
                    return NotFound("Certification not found.");
                return Ok("Certification deleted successfully.");
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
