namespace Models.Entities;

public class TrainerSkill : BaseEntity
{
    public string TrainerProfileId { get; set; }
    public TrainerProfile TrainerProfile { get; set; }
    
    public string SkillId { get; set; }
    public Skill Skill { get; set; }
}