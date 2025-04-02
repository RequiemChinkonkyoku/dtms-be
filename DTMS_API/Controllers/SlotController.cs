using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/slots")]

    public class SlotController : Controller
    {
        private readonly ISlotService _slotService;

        public SlotController(ISlotService slotService)
        {
            _slotService = slotService;
        }
        [HttpGet("classes/{classId}/dogs/{dogId}")]
        public async Task<IActionResult> GetSlotsByClassId(string classId, string dogId)
        {
            if (string.IsNullOrWhiteSpace(classId))
                return BadRequest("ClassId is required.");

            try
            {
                var slots = await _slotService.GetSlotsByClassAndDog(classId, dogId);
                return Ok(slots);
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
