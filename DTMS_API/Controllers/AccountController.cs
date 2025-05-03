using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.DTOs.Account;
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
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAccountById(string id)
    {
        try
        {
            var account = await _accountService.GetAccountById(id);
            return Ok(account);
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { message = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "An error occurred.", details = ex.Message });
        }
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
            return BadRequest(new { message = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500,
                new { message = "An unexpected error occurred. Please try again later.", error = ex.Message });
        }
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAccount(string id, [FromBody] AccountUpdateRequest request)
    {
        try
        {
            var updated = await _accountService.UpdateAccountAsync(id, request);
            return Ok(updated); 
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }


    [HttpPost("forgotPassword")]
    public async Task<IActionResult> ForgetPassword(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return BadRequest("Email is required.");
        }

        try
        {
            var response = await _accountService.ForgotPasswordAsync(email);

            if (response != null)
            {
                return Ok(new { message = response });
            }
            else
            {
                return BadRequest(new { message = "Failed to send OTP." });
            }
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { message = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "An unexpected error occurred. Please try again later.", error = ex.Message });
        }
    }

    [HttpPut("resetPassword")]
    public async Task<IActionResult> ResetPassword(string email, string otpCode, string newPassword)
    {
        try
        {
            var result = await _accountService.ResetPasswordAsync(email, otpCode, newPassword);

            if (result)
            {
                return Ok("Password has been reset successfully.");
            }

            return BadRequest("Password reset failed.");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occurred while resetting the password. Please try again later.");
        }
    }
    
    [HttpPut("{id}/activate")]
    public async Task<IActionResult> ActivateAccount(string id)
    {
        try
        {
            var result = await _accountService.ActivateAccountAsync(id);

            if (result != null)
            {
                return Ok("Account successfully reactivated.");
            }

            return BadRequest("Reactivation failed.");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }
    
    [HttpPut("{id}/convert-to-organization")]
    public async Task<IActionResult> ConvertToOrganization(string id)
    {
        try
        {
            var result = await _accountService.ConvertToOrganizationAsync(id);

            if (result != null)
            {
                return Ok("Account successfully converted to organization.");
            }

            return BadRequest("Conversion failed.");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeactivateAccount(string id)
    {
        try
        {
            var result = await _accountService.DeactivateAccountAsync(id);

            if (result != null)
            {
                return Ok("Account successfully deactivated.");
            }

            return BadRequest("Deactivation failed.");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "An error occurred. Please try again later.");
        }
    }
    
    [HttpPost("trainers/availability")]
    public async Task<IActionResult> GetAvailableTrainers(
           [FromBody] TrainerAvailabilityRequest request)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var availableTrainers = await _accountService.GetAvailableTrainersAsync(request);
            return Ok(availableTrainers);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { Message = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new
            {
                Message = "Error checking trainer availability",
                Detail = ex.Message
            });
        }
    }
}