using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.DTOs.Pretest.Request;
using Services.Interface;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Authorization;

namespace DTMS_API.Controllers
{
    [Authorize]
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

        [HttpPost("get-class-pretests")]
        public async Task<IActionResult> GetClassPretests([FromBody] GetPretestRequest request)
        {
            var response = await _pretestService.GetClassPretests(request);

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
        public async Task<IActionResult> UpdatePretestStatus(string id, UpdatePretestRequest request)
        {
            var response = await _pretestService.UpdatePretest(id, request);

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
