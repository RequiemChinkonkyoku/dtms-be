namespace Models.Entities;

public class TrainerSkill : BaseEntity
{
    public string TrainerId { get; set; }
    public Account Trainer { get; set; }
    
    public string SkillId { get; set; }
    public Skill Skill { get; set; }
}