namespace Models.Entities;

public class StaffProfile : BaseEntity
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Gender { get; set; }
    public int EmploymentType { get; set; }
    public DateTime DateOfHire { get; set; }

    public string AccountId { get; set; }
    public Account Account { get; set; } // Navigation property

    public string StaffRoleId { get; set; }
    public StaffRole StaffRole { get; set; }

    public ICollection<Blog> Blogs { get; set; }
}