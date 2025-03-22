using System.Reflection.Metadata;

namespace Models.Entities;

public class TrainerProfile : BaseEntity
{
    public int EmploymentType { get; set; }
    public DateTime DateOfHire { get; set; }
    public int EmploymentStatus { get; set; }

    public string AccountId { get; set; }
    public Account Account { get; set; } // Navigation property
}