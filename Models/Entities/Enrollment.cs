namespace Models.Entities;

public class Enrollment : BaseEntity
{
    public int Status { get; set; }
    public int RequiedNightStay { get; set; }

    public string ClassId { get; set; }
    public Class Class { get; set; }

    public string DogId { get; set; }
    public Dog Dog { get; set; }

    public string CageId { get; set; }
    public Cage Cage { get; set; }

    public string PaymentId { get; set; }
    public Payment Payment { get; set; }
}