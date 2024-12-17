namespace Models.Entities;

public class Payment : BaseEntity
{
    public decimal TotalAmount { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal AmountDue { get; set; }
    public string Status { get; set; }
    public DateTime PaymentTime { get; set; }

    // Foreign Keys
    public int EnrollmentId { get; set; } // 1-1 Relationship
    public Enrollment Enrollment { get; set; }

    public int? MembershipId { get; set; } // Many-to-One (Nullable)
    public Membership Membership { get; set; }

    public int PaymentMethodId { get; set; } // Many-to-One
    public PaymentMethod PaymentMethod { get; set; }
}