using Models.DTOs;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implement;

public class AccountService : IAccountService
{
    private readonly IUnitOfWork _unitOfWork;

    public AccountService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<List<Account>> GetAllAccounts()
    {
        var result = await _unitOfWork.Accounts.GetAll();
        return result;
    }

    public async Task<Account> CreateNewAccount(CreateAccountRequest request)
    {
        var account = new Account()
        {
            Email = request.Email,
            Password = request.Password,
            Username = request.Username,
            ImageUrl = request.ImageUrl,
            Status = request.Status,
            RegistrationTime = DateTime.UtcNow,
        };
        await _unitOfWork.Accounts.Add(account);
        await _unitOfWork.SaveChanges();
        return account;
    }
}