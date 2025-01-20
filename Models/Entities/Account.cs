namespace Models.Entities;

public class Account : BaseEntity
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ImageUrl { get; set; }
    public int Status { get; set; }
    public DateTime RegistrationTime { get; set; }

    // Discriminator for profile type
    public int? ProfileType { get; set; } // E.g., "Customer", "Trainer", "Staff"

    public ICollection<Chat> Chats { get; set; }

    public ICollection<Notification> Notifications { get; set; }
    
    public ICollection<AccountOtp> AccountOtps { get; set; }
}