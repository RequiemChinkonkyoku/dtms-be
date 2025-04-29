using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.DTOs.Response;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/dogDocuments")]
    public class DogDocumentController : ControllerBase
    {
        private readonly IDogDocumentService _documentService;
        public DogDocumentController(IDogDocumentService documentService)
        {
            _documentService =  documentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDogDocuments()
        {
            var response = await _documentService.GetAllDogDocuments();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDogDocumentById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var dogDocument = await _documentService.GetDogDocumentById(id);
                return Ok(dogDocument);
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

        [HttpGet("dog/{dogId}")]
        public async Task<IActionResult> GetDocumentsByDogId(string dogId)
        {
            var responses = await _documentService.GetDocumentsByDogId(dogId);

            if (responses == null || !responses.Any())
                return NotFound("No documents found for this dog.");

            return Ok(responses);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDogDocument(CreateDogDocumentRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var response = await _documentService.CreateDogDocumentAsync(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDogDocument([FromBody] UpdateDogDocumentRequest request, string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var response = await _documentService.UpdateDogDocumentAsync(id, request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDogDocument(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Invalid id.");

            try
            {
                var message = await _documentService.DeleteDogDocumentAsync(id);
                return Ok(message);
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
