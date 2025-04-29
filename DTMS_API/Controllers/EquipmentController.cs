using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/equipments")]
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;

        public EquipmentController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEquipments()
        {
            var response = await _equipmentService.GetAllEquipments();

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEquipment(CreateEquipmentRequest request)
        {
            var response = await _equipmentService.CreateEquipment(request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEquipment(UpdateEquipmentRequest request)
        {
            var response = await _equipmentService.UpdateEquipment(request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response.Message);
            }
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEquipmentById(string id)
        {
            var response = await _equipmentService.GetEquipmentById(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return NotFound(response.Message);
            }
        }

    }
}
