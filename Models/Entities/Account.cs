namespace Models.Entities;

public class Account : BaseEntity
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ImageUrl { get; set; }
    public int Status { get; set; }
    public DateTime RegistrationTime { get; set; }
    
    // // Discriminator for profile type
    // public string? ProfileType { get; set; } // E.g., "Customer", "Trainer", "Staff"

    // Nullable foreign keys
    public string? CustomerProfileId { get; set; }
    public CustomerProfile CustomerProfile { get; set; }

    public string? TrainerProfileId { get; set; }
    public TrainerProfile TrainerProfile { get; set; }

    public string? StaffProfileId { get; set; }
    public StaffProfile StaffProfile { get; set; }
}