using Models.DTOs;
using Models.Entities;

namespace Services.Interface;

public interface IAccountService
{
    Task<List<Account>> GetAllAccounts();
    Task<Account> CreateNewAccount(CreateAccountRequest request);
}