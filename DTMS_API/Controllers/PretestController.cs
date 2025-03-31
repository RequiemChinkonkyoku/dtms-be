using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Services.Interface;
using System.Runtime.CompilerServices;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/pretest")]
    public class PretestController : ControllerBase
    {
        private readonly IPretestService _pretestService;

        public PretestController(IPretestService pretestService)
        {
            _pretestService = pretestService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPretest()
        {
            var response = await _pretestService.GetAllPretest();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPretestById(string id)
        {
            var response = await _pretestService.GetPretestById(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpGet("get-class-pretests/{id}")]
        public async Task<IActionResult> GetClassPretests(string id)
        {
            var response = await _pretestService.GetClassPretests(id);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }

        [HttpPut("update-pretest-status/{id}")]
        public async Task<IActionResult> UpdatePretestStatus(string id, int pretestStatus)
        {
            var response = await _pretestService.UpdatePretestStatus(id, pretestStatus);

            if (response.Success)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest(response);
            }
        }
    }
}
