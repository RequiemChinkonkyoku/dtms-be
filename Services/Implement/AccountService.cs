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
}