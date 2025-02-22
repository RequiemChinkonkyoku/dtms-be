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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSkillById(string id)
        {
            var response = await _skillService.GetSkillById(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response.Message);
            }
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkill(string id)
        {
            var response = await _skillService.DeleteSkill(id);

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
