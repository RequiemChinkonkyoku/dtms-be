namespace Models.Entities;

public class PaymentMethod : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Status { get; set; }

    public ICollection<Transaction> Transactions { get; set; }
}