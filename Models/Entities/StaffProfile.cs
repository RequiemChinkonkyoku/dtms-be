namespace Models.Entities;

public class StaffProfile : BaseEntity
{
    public int AccountId { get; set; }
    public Account Account { get; set; } // Navigation property
}