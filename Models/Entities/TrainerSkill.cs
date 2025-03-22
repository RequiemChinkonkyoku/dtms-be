namespace Models.Entities;

public class TrainerSkill : BaseEntity
{
    public string TrainerId { get; set; }
    public Account Account { get; set; }
    
    public string SkillId { get; set; }
    public Skill Skill { get; set; }
}