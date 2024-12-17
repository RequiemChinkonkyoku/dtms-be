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
        var response = await _accountService.CreateNewAccount(request);
        return Ok(response);
    }
}