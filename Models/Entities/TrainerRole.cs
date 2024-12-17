using System.Reflection.Metadata;

namespace Models.Entities;

public class TrainerRole : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    
    public ICollection<TrainerProfile> TrainerProfiles { get; set; }
}