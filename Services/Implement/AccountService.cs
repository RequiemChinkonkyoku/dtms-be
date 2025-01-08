using AutoMapper;
using Models.DTOs;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implement;

public class AccountService : IAccountService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AccountService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async Task<List<Account>> GetAllAccounts()
    {
        var result = await _unitOfWork.Accounts.GetAll();
        return _mapper.Map<List<Account>>(result);
    }

    public async Task<Account> CreateNewAccount(CreateAccountRequest request)
    {
        if (request.ProfileType < 1 || request.ProfileType > 3)
            throw new ArgumentException("Invalid ProfileType. Must be 1 (Customer), 2 (Trainer), or 3 (Staff).");
        
        var account = new Account()
        {
            Email = request.Email,
            Password = request.Password,
            Username = request.Username,
            ImageUrl = request.ImageUrl,
            Status = 0,
            RegistrationTime = DateTime.UtcNow,
        };
        
        await _unitOfWork.Accounts.Add(account);
        await _unitOfWork.SaveChanges();
        
        switch (request.ProfileType)
        {
            case 1:
            {
                var profile = new CustomerProfile()
                {
                    FullName = request.FullName,
                    PhoneNumber = request.PhoneNumber,
                    Address = request.Address,
                    DateOfBirth = request.DateOfBirth,
                    Gender = request.Gender,
                    AccountId = account.Id,
                };
                await _unitOfWork.CustomerProfiles.Add(profile);
            }
                break;
            case 2:
            {
                var profile = new TrainerProfile()
                {
                    FullName = request.FullName,
                    PhoneNumber = request.PhoneNumber,
                    Address = request.Address,
                    DateOfBirth = request.DateOfBirth,
                    Gender = request.Gender,
                    AccountId = account.Id,
                };
                await _unitOfWork.TrainerProfiles.Add(profile);
            }
                break;
            case 3:
            {
                var profile = new StaffProfile()
                {
                    FullName = request.FullName,
                    PhoneNumber = request.PhoneNumber,
                    Address = request.Address,
                    DateOfBirth = request.DateOfBirth,
                    Gender = request.Gender,
                    AccountId = account.Id,
                };
                await _unitOfWork.StaffProfiles.Add(profile);
            }
                break;
        }
        await _unitOfWork.SaveChanges();
        
        return account;
    }
}