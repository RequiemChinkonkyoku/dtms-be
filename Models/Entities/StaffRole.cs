using System.Reflection.Metadata;

namespace Models.Entities;

public class StaffRole : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Status { get; set; }
    
    public ICollection<StaffProfile> StaffProfiles { get; set; }
}