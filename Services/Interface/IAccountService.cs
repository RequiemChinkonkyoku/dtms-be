using Microsoft.AspNetCore.Identity.Data;
using Models.DTOs;
using Models.Entities;

namespace Services.Interface;

public interface IAccountService
{
    Task<List<Account>> GetAllAccounts();
    Task<Account> CreateNewAccount(CreateAccountRequest request);
    Task<string> Login(AccountLoginRequest request);
    Task<Account> Register(AccountRegisterRequest request);
}