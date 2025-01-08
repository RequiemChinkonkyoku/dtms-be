using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/dogDocumentTypes")]
    public class DogDocumentTypeController : ControllerBase
    {
        private readonly IDogDocumentTypeService _documentTypeService;
        public DogDocumentTypeController(IDogDocumentTypeService documentTypeService)
        {
            _documentTypeService = documentTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDocumentType()
        {
            var response = await _documentTypeService.GetAllDocumentType();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDocumentTypeById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Id is required.");
            try
            {
                var dogBreed = await _documentTypeService.GetDogDocumentTypeByIdAsync(id);
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

        [HttpPost]
        public async Task<IActionResult> CreateDogDocumentType(CreateDogDocumentTypeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _documentTypeService.CreateDogDocumentTypeAsync(request);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDocumentType([FromBody] UpdateDogDocumentTypeRequest request, string id)
        {
            var response = await _documentTypeService.UpdateDogDocumentTypeAsync(id, request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDogDocumentType(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest("Invalid id.");

            try
            {
                var message = await _documentTypeService.DeleteDogDocumentTypeAsync(id);
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
