using Microsoft.AspNetCore.Identity.Data;
using Models.DTOs;
using Models.DTOs.Response;
using Models.Entities;

namespace Services.Interface;

public interface IAccountService
{
    Task<List<AllAccountsResponse>> GetAllAccounts();
    Task<Account> CreateNewAccount(CreateAccountRequest request);
    Task<string> Login(AccountLoginRequest request);
    Task<Account> Register(AccountRegisterRequest request);
    Task<bool> VerifyOtpAsync(string email, string otpCode);
}