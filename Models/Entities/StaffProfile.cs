namespace Models.Entities;

public class StaffProfile : BaseEntity
{
    public int EmploymentType { get; set; }
    public DateTime DateOfHire { get; set; }

    public string AccountId { get; set; }
    public Account Account { get; set; } // Navigation property
}