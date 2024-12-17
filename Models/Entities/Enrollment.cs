namespace Models.Entities;

public class Enrollment : BaseEntity
{
    public int PaymentId { get; set; }
    public Payment Payment { get; set; }
}