namespace Models.Entities;

public class Enrollment : BaseEntity
{
    public string PaymentId { get; set; }
    public Payment Payment { get; set; }
}