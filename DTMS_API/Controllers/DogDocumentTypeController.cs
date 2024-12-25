using Microsoft.AspNetCore.Mvc;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/dogDocumentTypes")]
    public class DogDocumentTypeController : Controller
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
    }
}
