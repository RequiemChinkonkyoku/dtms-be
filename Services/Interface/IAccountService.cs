using Microsoft.AspNetCore.Identity.Data;
using Models.DTOs;
using Models.DTOs.Account;
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
    Task<Account> GetAccountById(string id);
    Task<string> ForgotPasswordAsync(string email);
    Task<bool> ResetPasswordAsync(string email, string otpCode, string newPassword);
    Task<List<TrainerBasicInfoResponse>> GetAvailableTrainersAsync(TrainerAvailabilityRequest request);
    Task<Account> ConvertToOrganizationAsync(string accountId);
    Task<Account> DeactivateAccountAsync(string accountId);
    Task<Account> ActivateAccountAsync(string accountId);
    Task<Account> UpdateAccountAsync(string accountId, AccountUpdateRequest request);
}