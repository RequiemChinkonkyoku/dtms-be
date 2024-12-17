namespace Models.Entities;

public class Membership : BaseEntity
{
    public string Name { get; set; }
    public int RequiredPoints { get; set; }
    public string Description { get; set; }
    public decimal DiscountAmount { get; set; }

    // Navigation Property
    public ICollection<CustomerProfile> CustomerProfiles { get; set; }
}