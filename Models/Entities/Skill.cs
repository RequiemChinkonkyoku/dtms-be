using System.Reflection.Metadata;

namespace Models.Entities;

public class Skill : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Status { get; set; }

    public ICollection<TrainerSkill> TrainerSkills { get; set; }

    public ICollection<Lesson> Lessons { get; set; }
}