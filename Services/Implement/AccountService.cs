using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using AutoMapper;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models.DTOs;
using Models.DTOs.Account;
using Models.DTOs.Response;
using Models.Entities;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implement;

public class AccountService : IAccountService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IConfiguration _config;

    public AccountService(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration config)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _config = config;
    }

    public async Task<List<AllAccountsResponse>> GetAllAccounts()
    {
        var accounts = await _unitOfWork.Accounts.GetAll();

        var responses = accounts.Select(account => new AllAccountsResponse
        {
            Id = account.Id,
            Username = account.Username,
            Email = account.Email,
            // Password = account.Password, 
            ImageUrl = account.ImageUrl,
            Status = account.Status,
            RegistrationTime = account.RegistrationTime,
            FullName = account.FullName,
            PhoneNumber = account.PhoneNumber,
            Address = account.Address,
            DateOfBirth = account.DateOfBirth,
            Gender = account.Gender,
            MembershipPoints = account.MembershipPoints,
            RoleId = account.RoleId,
            MembershipId = account.MembershipId,
        }).ToList();

        return responses;
    }

    public async Task<Account> GetAccountById(string id)
    {
        var account = await _unitOfWork.Accounts.GetById(id);

        if (account == null)
            throw new KeyNotFoundException("Account not found.");

        return account;
    }

    public async Task<Account> CreateNewAccount(CreateAccountRequest request)
    {
        try
        {
            var accounts = await _unitOfWork.Accounts.GetAll();
            var existingAccount = accounts.FirstOrDefault
                (a => a.Email == request.Email || a.Username == request.Username);

            if (existingAccount != null)
            {
                throw new InvalidOperationException("An account with this email or username already exists.");
            }
            
            var roles = await _unitOfWork.Roles.GetAll();
            var role = roles.FirstOrDefault(r => r.Name == request.RoleName);
            if (role == null)
            {
                throw new InvalidOperationException("Invalid RoleName. No matching role found.");
            }

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            var account = new Models.Entities.Account()
            {
                Email = request.Email,
                Password = passwordHash,
                Username = request.Username,
                ImageUrl = request.ImageUrl,
                Status = 1,
                RegistrationTime = DateTime.UtcNow,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow,
                FullName = request.FullName,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
                DateOfBirth = request.DateOfBirth,
                Gender = request.Gender,
                RoleId = role.Id,
                MembershipId = "a1b2c3d4e5f67890a1b2c3d4e5f67890"
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
            var roles = await _unitOfWork.Roles.GetAll();
            var role = roles.FirstOrDefault(r => r.Id == account.RoleId);

            var tokenHandler = new JwtSecurityTokenHandler();
            // IConfiguration config = new ConfigurationBuilder()
            //     .SetBasePath(Directory.GetCurrentDirectory())
            //     .AddJsonFile("appsettings.json", true, true)
            //     .Build();
            // var strConn = config["ConnectionStrings:PodBookingSystemDB"];
            var key = Encoding.UTF8.GetBytes(_config["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, account.Id.ToString()),
                    new Claim(ClaimTypes.Role, role.Name.ToString()),
                }),
                Expires = DateTime.UtcNow.AddMinutes(90),
                Issuer = _config["Jwt:Issuer"],
                Audience = _config["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
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

    public async Task<Account> Register(AccountRegisterRequest request)
    {
        try
        {
            var accounts = await _unitOfWork.Accounts.GetAll();
            var existingAccount = accounts.FirstOrDefault
                (a => a.Email == request.Email || a.Username == request.Username);

            if (existingAccount != null)
            {
                throw new InvalidOperationException("An account with this email or username already exists.");
            }

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            var account = new Account()
            {
                Email = request.Email,
                Password = passwordHash,
                Username = request.Username,
                ImageUrl = "empty",
                Status = 0,
                RegistrationTime = DateTime.UtcNow,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow,
                FullName = request.FullName,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
                DateOfBirth = request.DateOfBirth,
                Gender = request.Gender,
                MembershipPoints = 0,
                MembershipId = "a1b2c3d4e5f67890a1b2c3d4e5f67890", // Hardcoded membership ID
                RoleId = "a4b5c67890d1e2f3a4b5c67890d1e2f3" // Hardcoded role ID
            };

            await _unitOfWork.Accounts.Add(account);
            await _unitOfWork.SaveChanges();

            await SendOtpAsync(account.Email);

            return account;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }

    private string SendEmailAsync(string _to, string _subject, string name, string otpCode, string template)
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        var _email = config["GmailSender:Email"];
        var _password = config["GmailSender:Password"];

        string baseDir = AppContext.BaseDirectory;
        string templatePath = Path.Combine(baseDir, "EmailTemplates", template);

        if (!File.Exists(templatePath))
        {
            throw new FileNotFoundException("Email template not found at: " + templatePath);
        }

        string emailBody = File.ReadAllText(templatePath);

        emailBody = emailBody.Replace("{{Username}}", name)
            .Replace("{{OTPCode}}", otpCode);

        MailMessage message = new MailMessage(_email, _to, _subject, emailBody)
        {
            BodyEncoding = System.Text.Encoding.UTF8,
            SubjectEncoding = System.Text.Encoding.UTF8,
            IsBodyHtml = true,
            ReplyToList = { new MailAddress(_email) },
            Sender = new MailAddress(_email)
        };

        using var smtpClient = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            EnableSsl = true,
            Credentials = new NetworkCredential(_email, _password)
        };

        try
        {
            smtpClient.Send(message);
            return "A verification email has been sent to your inbox.";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return "Email cannot be sent.";
        }
    }


    private async Task<bool> SendOtpAsync(string email)
    {
        var accounts = await _unitOfWork.Accounts.GetAll();
        var account = accounts.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        if (account == null)
        {
            throw new ArgumentException("No user found with this email.");
        }

        if (account.Status == 1)
        {
            throw new ArgumentException("User is already verified.");
        }

        var otpList = await _unitOfWork.AccountOtps.GetAll();
        var existingOtp = otpList.FirstOrDefault(o => o.AccountId == account.Id);
        var currentTime = DateTime.UtcNow;

        if (existingOtp != null && existingOtp.ExpirationTime > currentTime)
        {
            var cooldownPeriod = TimeSpan.FromMinutes(2);
            if (existingOtp.ExpirationTime - currentTime < cooldownPeriod)
            {
                throw new ArgumentException("OTP was recently generated. Please wait before requesting a new one.");
            }
        }

        string newOtpCode = await GenerateCustomOtp();
        var newExpirationTime = currentTime.AddMinutes(15);

        var newAccountOtp = new AccountOtp
        {
            OtpCode = newOtpCode,
            ExpirationTime = newExpirationTime,
            AccountId = account.Id
        };

        await _unitOfWork.AccountOtps.Add(newAccountOtp);
        await _unitOfWork.SaveChanges();

        SendEmailAsync(account.Email, "noreply", account.Username, newOtpCode, "register_verify.html");

        return true;
    }

    private async Task<string> GenerateCustomOtp()
    {
        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string numbers = "0123456789";
        var random = new Random();

        var letterPart = new string(Enumerable.Repeat(letters, 3)
            .Select(s => s[random.Next(s.Length)])
            .ToArray());

        var numberPart = new string(Enumerable.Repeat(numbers, 4)
            .Select(s => s[random.Next(s.Length)])
            .ToArray());

        string result = letterPart + numberPart;

        var otpList = await _unitOfWork.AccountOtps.GetAll();
        var existingOtp = otpList.FirstOrDefault(o => o.OtpCode.Equals(result, StringComparison.OrdinalIgnoreCase));
        if (existingOtp != null)
        {
            result = await GenerateCustomOtp();
        }

        return result;
    }

    public async Task<bool> VerifyOtpAsync(string email, string otpCode)
    {
        var accounts = await _unitOfWork.Accounts.GetAll();
        var account = accounts.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        if (account == null)
        {
            throw new ArgumentException("No user found with this email.");
        }

        var otpList = await _unitOfWork.AccountOtps.GetAll();
        var existingOtp = otpList.FirstOrDefault(o => o.AccountId == account.Id);

        if (existingOtp == null)
        {
            throw new ArgumentException("No OTP record found for this user.");
        }

        if (!existingOtp.OtpCode.Equals(otpCode, StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentException("Invalid OTP code.");
        }

        if (existingOtp.ExpirationTime < DateTime.UtcNow)
        {
            throw new ArgumentException("The OTP has expired. Please request a new OTP.");
        }

        if (existingOtp.IsExpiredOrUsed)
        {
            throw new ArgumentException("This OTP code has already been used.");
        }

        account.Status = 1;
        await _unitOfWork.Accounts.Update(account);
        await _unitOfWork.SaveChanges();

        existingOtp.IsExpiredOrUsed = true;

        await _unitOfWork.AccountOtps.Update(existingOtp);
        await _unitOfWork.SaveChanges();

        SendEmailAsync(account.Email, "Successful Registration", account.FullName, "", "register_success.html");
        
        return true;
    }

    public async Task<string> ForgotPasswordAsync(string email)
    {
        var accounts = await _unitOfWork.Accounts.GetAll();
        var account = accounts.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        if (account == null)
        {
            throw new ArgumentException("No user found with this email.");
        }

        string otpCode = await GenerateCustomOtp();
        var expirationTime = DateTime.UtcNow.AddMinutes(15); 
        
        var otpList = await _unitOfWork.AccountOtps.GetAll();
        var existingOtp = otpList.FirstOrDefault(o => o.AccountId == account.Id);

        if (existingOtp != null)
        {
            existingOtp.OtpCode = otpCode;
            existingOtp.ExpirationTime = expirationTime;
            existingOtp.IsExpiredOrUsed = false;
            await _unitOfWork.AccountOtps.Update(existingOtp);
            await _unitOfWork.SaveChanges();
        }
        else
        {
            var newAccountOtp = new AccountOtp()
            {
                OtpCode = otpCode,
                ExpirationTime = expirationTime,
                AccountId = account.Id
            };
            await _unitOfWork.AccountOtps.Add(newAccountOtp);
            await _unitOfWork.SaveChanges();
        }

        SendEmailAsync(account.Email, "Password Reset", account.FullName, otpCode, "forgot_password.html");

        return "A password reset OTP has been sent to your email.";
    }

    public async Task<bool> ResetPasswordAsync(string email, string otpCode, string newPassword)
    {
        var accounts = await _unitOfWork.Accounts.GetAll();
        var account = accounts.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        if (account == null)
        {
            throw new ArgumentException("No user found with this email.");
        }

        var otpList = await _unitOfWork.AccountOtps.GetAll();
        var existingOtp = otpList.FirstOrDefault(o => o.AccountId == account.Id);

        if (existingOtp == null)
        {
            throw new ArgumentException("No OTP record found for this user.");
        }

        if (existingOtp.IsExpiredOrUsed || existingOtp.ExpirationTime < DateTime.UtcNow)
        {
            throw new ArgumentException("The OTP is invalid or has expired.");
        }

        if (!existingOtp.OtpCode.Equals(otpCode, StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentException("Invalid OTP code.");
        }

        if (string.IsNullOrWhiteSpace(newPassword))
        {
            throw new ArgumentException("Password cannot be empty.");
        }

        var passwordPattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).{8,}$";
        if (!Regex.IsMatch(newPassword, passwordPattern))
        {
            throw new ArgumentException(
                "Password must be at least 8 characters long and include at least one uppercase letter, one number, and one special character.");
        }

        account.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
        await _unitOfWork.Accounts.Update(account);
        await _unitOfWork.SaveChanges();

        existingOtp.IsExpiredOrUsed = true;
        await _unitOfWork.AccountOtps.Update(existingOtp);
        await _unitOfWork.SaveChanges();
        
        SendEmailAsync(account.Email, "Password Reset Successfully", account.FullName, "", "reset_password_success.html");

        return true;
    }
    
    public async Task<List<TrainerBasicInfoResponse>> GetAvailableTrainersAsync(TrainerAvailabilityRequest request)
    {
        if (request.StartingDate < DateOnly.FromDateTime(DateTime.UtcNow))
            throw new ArgumentException("Start date cannot be in the past");

        if (request.DurationInWeeks < 1)
            throw new ArgumentException("Minimum duration is 1 week");

        if (request.SlotData?.Count == 0)
            throw new ArgumentException("At least one time slot required");

        var availableTrainers = await _unitOfWork.Accounts.GetAvailableTrainersAsync(request);

        return _mapper.Map<List<TrainerBasicInfoResponse>>(availableTrainers);
    }
    
    public async Task<Account> ConvertToOrganizationAsync(string accountId)
    {
        var account = await _unitOfWork.Accounts.GetById(accountId);

        if (account == null)
            throw new ArgumentException($"Account with ID '{accountId}' not found.");
        
        if (account.RoleId == "b5c67890d1e2f3a4b5c67890d1e2f3a4")
            return account; 
        
        account.RoleId = "b5c67890d1e2f3a4b5c67890d1e2f3a4";

        await _unitOfWork.Accounts.Update(account);
        await _unitOfWork.SaveChanges();

        return account;
    }
    
    public async Task<Account> DeactivateAccountAsync(string accountId)
    {
        var account = await _unitOfWork.Accounts.GetById(accountId);

        if (account == null)
            throw new ArgumentException($"Account with ID '{accountId}' not found.");

        if (account.Status == 2)
            return account; // Already deactivated

        account.Status = 2; // Set to inactive
        await _unitOfWork.Accounts.Update(account);
        await _unitOfWork.SaveChanges();

        return account;
    }
    public async Task<Account> ActivateAccountAsync(string accountId)
    {
        var account = await _unitOfWork.Accounts.GetById(accountId);

        if (account == null)
            throw new ArgumentException($"Account with ID '{accountId}' not found.");

        if (account.Status == 1)
            return account; // Already active

        account.Status = 1; // Set to active
        await _unitOfWork.Accounts.Update(account);
        await _unitOfWork.SaveChanges();

        return account;
    }
    
    public async Task<Account> UpdateAccountAsync(string accountId, AccountUpdateRequest request)
    {
        var account = await _unitOfWork.Accounts.GetById(accountId);

        if (account == null)
            throw new ArgumentException($"Account with ID '{accountId}' not found.");

        account.FullName = request.FullName;
        account.PhoneNumber = request.PhoneNumber;
        account.Address = request.Address;
        account.DateOfBirth = request.DateOfBirth;
        account.Gender = request.Gender;
        account.ImageUrl = request.ImageUrl;

        await _unitOfWork.Accounts.Update(account);
        await _unitOfWork.SaveChanges();

        return account;
    }
}