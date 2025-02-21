using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Response;
using Services.Interface;
using System;
using System.Threading.Tasks;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/trainerProfile")]
    public class TrainerProfileController : ControllerBase
    {
        private readonly ITrainerProfileService _trainerProfileService;

        public TrainerProfileController(ITrainerProfileService trainerProfileService)
        {
            _trainerProfileService = trainerProfileService;
        }

        [HttpGet("{accountId}")]
        public async Task<ActionResult<TrainerProfileResponse>> GetTrainerProfile(string accountId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var response = await _trainerProfileService.GetTrainerProfile(accountId);

                if (response == null)
                {
                    return NotFound("Trainer profile not found.");
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}