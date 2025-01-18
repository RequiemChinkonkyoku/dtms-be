using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
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
        try
        {
            if (request.ProfileType < 1 || request.ProfileType > 3)
                throw new ArgumentException("Invalid ProfileType. Must be 1 (Customer), 2 (Trainer), or 3 (Staff).");

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
            
            var account = new Account()
            {
                Email = request.Email,
                Password = passwordHash,
                Username = request.Username,
                ImageUrl = request.ImageUrl,
                Status = 0,
                RegistrationTime = DateTime.UtcNow,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow,
            };

            await _unitOfWork.Accounts.Add(account);
            await _unitOfWork.SaveChanges();

            return account;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            Console.WriteLine($"StackTrace: {ex.StackTrace}");
            throw new HttpRequestException("Failed to create an account", ex);
        }
    }
    
    public async Task<string> Login(AccountLoginRequest request)
    {
        var account = await ValidateUser(request);

        if (account != null)
        {
            // Generate JWT token
            var tokenHandler = new JwtSecurityTokenHandler();
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:PodBookingSystemDB"];
            var key = Encoding.UTF8.GetBytes(config["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, account.Id.ToString()),
                }),
                Expires = DateTime.UtcNow.AddMinutes(90),
                Issuer = config["Jwt:Issuer"],
                Audience = config["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        return null;
    }

    private async Task<Account> ValidateUser(AccountLoginRequest request)
    {
        var accounts = await _unitOfWork.Accounts.GetAll();
        if (!accounts.IsNullOrEmpty())
        {
            var account = accounts.FirstOrDefault(x => x.Email.Equals(request.Email));
            if (account != null)
            {
                if (account.Status == 1)
                {
                    if (BCrypt.Net.BCrypt.Verify(request.Password, account.Password))
                    {
                        return account;
                    }
                }
            }
        }
        return null;
    }
}