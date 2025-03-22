using System.Reflection.Metadata;

namespace Models.Entities;

public class Account : BaseEntity
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ImageUrl { get; set; }
    public int Status { get; set; }
    public DateTime RegistrationTime { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Gender { get; set; }
    public int MembershipPoints { get; set; }
    
    public string RoleId { get; set; }
    public Role Role { get; set; }
    
    public string MembershipId { get; set; }
    public Membership Membership { get; set; }

    public ICollection<Chat> Chats { get; set; }

    public ICollection<Notification> Notifications { get; set; }
    
    public ICollection<AccountOtp> AccountOtps { get; set; }
    
    public ICollection<LegalDocument> LegalDocuments { get; set; }
    
    public ICollection<WishList> WishLists { get; set; }
    
    public ICollection<Payment> Payments { get; set; }
    
    public ICollection<DogOwnership> DogOwnerships { get; set; }
    
    public ICollection<Blog> Blogs { get; set; }
    
    public ICollection<Course> Courses { get; set; }
    
    public ICollection<Certifications> Certifications { get; set; }
    
    public ICollection<Enrollment> Enrollments { get; set; }
    
    public ICollection<TrainerSpecialization> TrainerSpecializations { get; set; }
    
    public ICollection<TrainerSkill> TrainerSkills { get; set; }
    
    public ICollection<TrainerAssignment> TrainerAssignments { get; set; }
    
    public ICollection<Availability> Availabilities { get; set; }
    
    public ICollection<TrainingReport> TrainingReports { get; set; }
    
    public ICollection<ProgressReport> ProgressReports { get; set; }
}