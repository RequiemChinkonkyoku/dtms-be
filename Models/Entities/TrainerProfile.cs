using System.Reflection.Metadata;

namespace Models.Entities;

public class TrainerProfile : BaseEntity
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public int Gender { get; set; }
    public int EmploymentType { get; set; }
    public DateOnly DateOfHire { get; set; }
    public int EmploymentStatus { get; set; }
    public int Status { get; set; }
    public DateTime RegistrationTime { get; set; }
    
    public string AccountId { get; set; }
    public Account Account { get; set; } // Navigation property
    
    public string TrainerRoleId { get; set; }
    public TrainerRole TrainerRole { get; set; }
    
    public ICollection<Certifications> Certifications { get; set; }
    
    public ICollection<TrainerSkill> TrainerSkills { get; set; }
    
    public ICollection<Course> Courses { get; set; }
}