namespace Models.Entities;

public class Payment : BaseEntity
{
    public decimal TotalAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal AmountDue { get; set; }
    public string Status { get; set; }
    public DateTime PaymentTime { get; set; }

    // Foreign Keys
    public string EnrollmentId { get; set; } // 1-1 Relationship
    public Enrollment Enrollment { get; set; }

    public string? MembershipId { get; set; } // Many-to-One (Nullable)
    public Membership Membership { get; set; }

    public string PaymentMethodId { get; set; } // Many-to-One
    public PaymentMethod PaymentMethod { get; set; }
    
    public string CustomerId { get; set; }
    public Account Account { get; set; }
}