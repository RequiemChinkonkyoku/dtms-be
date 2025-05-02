using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.LegalDocument;
using Models.Entities;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Authorize]
    [Route("api/legalDocument")]
    [ApiController]
    public class LegalDocumentController : ControllerBase
    {
        private readonly ILegalDocumentService _legalDocumentService;

        public LegalDocumentController(ILegalDocumentService legalDocumentService)
        {
            _legalDocumentService = legalDocumentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLegalDocuments()
        {
            var response = await _legalDocumentService.GetAllLegalDocuments();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLegalDocumentById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var legalDocument = await _legalDocumentService.GetLegalDocumentById(id);
                if (legalDocument.Success)
                {
                    return Ok(legalDocument);
                }
                else
                {
                    return NotFound(legalDocument);
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

        [HttpPost]
        public async Task<IActionResult> CreateMembership(CreateLegalDocumentRequest request)
        {
            try
            {
                var response = await _legalDocumentService.CreateLegalDocumentAsync(request);
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

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLegalDocument(string id, CreateLegalDocumentRequest request)
        {
            try
            {
                var response = await _legalDocumentService.UpdateLegalDocumentAsync(id, request);
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
        [HttpPut("approval/{id}")]
        public async Task<IActionResult> UpdateDocumentStatusAndDescription(string id, [FromBody] UpdateLegalDocumentRequest request)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Document ID is required.");

            try
            {
                var response = await _legalDocumentService.LegalDocumentAprovalAsync(id, request);
                return Ok(response);
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLegalDocument(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var response = await _legalDocumentService.DeleteLegalDocumentAsync(id);
                if (!response)
                    return NotFound("Legal Document not found.");
                return Ok("Legal Document deleted successfully.");
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
