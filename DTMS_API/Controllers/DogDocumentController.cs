using Microsoft.AspNetCore.Mvc;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/dogDocuments")]
    public class DogDocumentController : Controller
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
    }
}
