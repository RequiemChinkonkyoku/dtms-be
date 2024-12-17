namespace Models.Entities;

public class TrainerProfile : BaseEntity
{
    public int AccountId { get; set; }
    public Account Account { get; set; } // Navigation property
}