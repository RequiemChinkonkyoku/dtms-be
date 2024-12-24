using System.Reflection.Metadata;

namespace Models.Entities;

public class CustomerProfile : BaseEntity
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public int MembershipPoints { get; set; }

    // Foreign Keys
    public string MembershipId { get; set; }
    public Membership Membership { get; set; } // Navigation property

    public string AccountId { get; set; }
    public Account Account { get; set; } // Navigation property

    public string CustomerRoleId { get; set; }
    public CustomerRole CustomerRole { get; set; }

    public ICollection<Dog> Dogs { get; set; }

    public ICollection<LegalDocument> LegalDocuments { get; set; }

    public ICollection<TrainerReport> TrainerReports { get; set; }

    public ICollection<WishList> WishLists { get; set; }
}