using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Response;
using Models.Entities;
using Services.Interface;

namespace DTMS_API.Controllers;

[ApiController]
[Route("api/customerProfile")]
public class CustomerProfileController : ControllerBase
{
    private readonly ICustomerProfileService _customerProfileService;

    public CustomerProfileController(ICustomerProfileService customerProfileService)
    {
        _customerProfileService = customerProfileService;
    }

    [HttpGet("{accountId}")]
    public async Task<ActionResult<CustomerProfileResponse>> GetCustomerProfile(string accountId)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var response = await _customerProfileService.GetCustomerProfile(accountId);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}