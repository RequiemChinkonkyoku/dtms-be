namespace Models.Entities;

public class Role : BaseEntity
{
    public string Name { get; set; }
    public int Status { get; set; }
    public string Description { get; set; }
    
    public ICollection<Account> Accounts { get; set; }

    public bool IsTrainerRole =>
            Name == "Trainer_Lead" ||
            Name == "Trainer_Member";
}