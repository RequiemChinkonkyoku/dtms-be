using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.Entities;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/skills")]
    public class SkillController : ControllerBase
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSkills()
        {
            var response = await _skillService.GetAllSkills();

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSkill(CreateSkillRequest request)
        {
            var response = await _skillService.CreateSkill(request);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSkill(UpdateSkillRequest request)
        {
            var response = await _skillService.UpdateSkill(request);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response.Message);
            }
        }
    }
}
