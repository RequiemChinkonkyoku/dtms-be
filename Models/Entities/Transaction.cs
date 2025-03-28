namespace Models.Entities;

public class Transaction : BaseEntity
{
    public decimal TotalAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal ActualPrice { get; set; }
    public int Status { get; set; }
    public DateTime PaymentTime { get; set; }
    public string OrderId { get; set; }
    public string PaymentId { get; set; }

    public string EnrollmentId { get; set; }
    public Enrollment Enrollment { get; set; }

    public string? MembershipId { get; set; }
    public Membership Membership { get; set; }

    public string PaymentMethodId { get; set; }
    public PaymentMethod PaymentMethod { get; set; }

    public string CustomerId { get; set; }
    public Account Customer { get; set; }
}