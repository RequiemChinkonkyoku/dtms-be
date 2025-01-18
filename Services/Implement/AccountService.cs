using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Mail;
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
            if (request.ProfileType is null || request.ProfileType < 1 || request.ProfileType > 3)
            {
                throw new ArgumentException("Invalid ProfileType. Must be 1 (Customer), 2 (Trainer), or 3 (Staff).");
            }

            var accounts = await _unitOfWork.Accounts.GetAll();
            // Check if the email or username already exists
            var existingAccount = accounts.FirstOrDefault(a =>
                a.Email == request.Email || a.Username == request.Username);
            if (existingAccount != null)
            {
                throw new InvalidOperationException("An account with this email or username already exists.");
            }

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            // Create a new account entity
            var account = new Account
            {
                Email = request.Email,
                Password = passwordHash,
                Username = request.Username,
                Status = 0,
                ImageUrl = "empty",
                RegistrationTime = DateTime.UtcNow,
                CreatedTime = DateTime.UtcNow,
                LastUpdatedTime = DateTime.UtcNow
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

    private string SendEmailAsync(string _to, string _subject, string name, string otpCode)
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        var _email = config["GmailSender:Email"];
        var _password = config["GmailSender:Password"];

        // Read the email template
        string templatePath = Path.Combine(Directory.GetCurrentDirectory(), "EmailTemplates", "register_verify.html");
        string emailBody = File.ReadAllText(templatePath);

        // Replace placeholders with actual values
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
        // Step 1: Retrieve the user based on the provided email.
        var accounts = await _unitOfWork.Accounts.GetAll();
        var account = accounts.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        if (account == null)
        {
            throw new ArgumentException("No user found with this email.");
        }

        // Step 2: Check if the user is already verified.
        if (account.Status == 1)
        {
            throw new ArgumentException("User is already verified.");
        }

        // Step 3: Check if an existing OTP for the user is still valid.
        var otpList = await _unitOfWork.AccountOtps.GetAll();
        var existingOtp = otpList.FirstOrDefault(o => o.AccountId == account.Id);
        var currentTime = DateTime.UtcNow;

        if (existingOtp != null && existingOtp.ExpirationTime > currentTime)
        {
            // If the existing OTP is still valid, enforce a cooldown period before resending.
            var cooldownPeriod = TimeSpan.FromMinutes(2);
            if (existingOtp.ExpirationTime - currentTime < cooldownPeriod)
            {
                throw new ArgumentException("OTP was recently generated. Please wait before requesting a new one.");
            }
        }

        // Step 4: Generate a new OTP with 3 letters and 4 numbers.
        string newOtpCode = await GenerateCustomOtp();
        var newExpirationTime = currentTime.AddMinutes(15); // Set expiration time for 15 minutes.

        var newAccountOtp = new AccountOtp
        {
            OtpCode = newOtpCode,
            ExpirationTime = newExpirationTime,
            AccountId = account.Id
        };

        await _unitOfWork.AccountOtps.Add(newAccountOtp);
        await _unitOfWork.SaveChanges();

        // Step 5: Send the OTP via email.
        SendEmailAsync(account.Email, "noreply", account.Username, newOtpCode);

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
        // Step 1: Retrieve the user by their email.
        var accounts = await _unitOfWork.Accounts.GetAll();
        var account = accounts.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

        if (account == null)
        {
            throw new ArgumentException("No user found with this email.");
        }

        // Step 2: Retrieve the OTP record for the user.
        var otpList = await _unitOfWork.AccountOtps.GetAll();
        var existingOtp = otpList.FirstOrDefault(o => o.AccountId == account.Id);

        if (existingOtp == null)
        {
            throw new ArgumentException("No OTP record found for this user.");
        }

        // Step 3: Check if the provided OTP matches the stored OTP.
        if (!existingOtp.OtpCode.Equals(otpCode, StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentException("Invalid OTP code.");
        }

        // Step 4: Check if the OTP has expired.
        if (existingOtp.ExpirationTime < DateTime.UtcNow)
        {
            throw new ArgumentException("The OTP has expired. Please request a new OTP.");
        }

        // Step 5: Check if the OTP has already been used.
        if (existingOtp.IsExpiredOrUsed)
        {
            throw new ArgumentException("This OTP code has already been used.");
        }

        // Step 6: Update user status to verified (Status = 1).
        account.Status = 1;
        await _unitOfWork.Accounts.Update(account);
        await _unitOfWork.SaveChanges();

        // Step 7: Mark the OTP as used to prevent reuse.
        existingOtp.IsExpiredOrUsed = true;

        await _unitOfWork.AccountOtps.Update(existingOtp);
        await _unitOfWork.SaveChanges();

        // Step 8: Return true to indicate successful verification.
        return true;
    }
}