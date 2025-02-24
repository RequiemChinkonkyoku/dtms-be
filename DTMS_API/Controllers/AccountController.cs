using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.Entities;
using Services.Implement;
using Services.Interface;

namespace DTMS_API.Controllers;

[ApiController]
[Route("api/accounts")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAccounts()
    {
        var response = await _accountService.GetAllAccounts();
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewAccount(CreateAccountRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var response = await _accountService.CreateNewAccount(request);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(AccountLoginRequest request)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _accountService.Login(request);
            return Ok(new { Token = response });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return StatusCode(500, new { Message = "An error occurred while processing your request." });
        }
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] AccountRegisterRequest request)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _accountService.Register(request);
            return Ok(response);
            //return CreatedAtAction(nameof(UserController.GetUserById), new { id = response.Id }, response);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An unexpected error occurred. " + ex.Message);
        }
    }

    [HttpPost("Verify/{otp}")]
    public async Task<IActionResult> VerifyOtp(string email, string otp)
    {
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(otp))
        {
            return BadRequest("Email and OTP code are required.");
        }

        try
        {
            // Use the service to verify the OTP code
            var isVerified = await _accountService.VerifyOtpAsync(email, otp);

            if (isVerified)
            {
                return Ok(new { message = "OTP verified successfully. User status has been updated." });
            }
            else
            {
                return BadRequest(new { message = "Failed to verify OTP." });
            }
        }
        catch (ArgumentException ex)
        {
            // Return a bad request response with the error message
            return BadRequest(new { message = ex.Message });
        }
        catch (Exception ex)
        {
            // Return a generic 500 error response for unexpected issues
            return StatusCode(500,
                new { message = "An unexpected error occurred. Please try again later.", error = ex.Message });
        }
    }
}