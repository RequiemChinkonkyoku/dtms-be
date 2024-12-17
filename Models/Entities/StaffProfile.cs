namespace Models.Entities;

public class StaffProfile : BaseEntity
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public int Gender { get; set; }
    public int EmploymentType { get; set; }
    public DateOnly DateOfHire { get; set; }
    
    public int AccountId { get; set; }
    public Account Account { get; set; } // Navigation property
    
    public int StaffRoleId { get; set; }
    public StaffRole StaffRole { get; set; }
    
    public ICollection<Blog> Blogs { get; set; }
}