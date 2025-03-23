using System.Reflection.Metadata;

namespace Models.Entities;

public class CustomerProfile : BaseEntity
{
    public string AccountId { get; set; }
    public Account Account { get; set; } // Navigation property
}