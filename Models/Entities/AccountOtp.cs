using System.ComponentModel.DataAnnotations;

namespace Models.Entities;

public class AccountOtp : BaseEntity
{
    [Required]
    public string OtpCode { get; set; }

    [Required]
    public DateTime ExpirationTime { get; set; }

    [Required]
    public string AccountId { get; set; }
    public Account Account { get; set; }

    public bool IsExpiredOrUsed { get; set; } = false;
}