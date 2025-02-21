using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Response;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers;

[ApiController]
[Route("api/staffProfile")]
public class StaffProfileController : ControllerBase
{
    private readonly IStaffProfileService _staffProfileService;

    public StaffProfileController(StaffProfileService staffProfileService)
    {
        _staffProfileService = staffProfileService;
    }
    
    [HttpGet("{accountId}")]
    public async Task<ActionResult<StaffProfileResponse>> GetStaffProfile(string accountId)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var response = await _staffProfileService.GetStaffProfile(accountId);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}