namespace Models.Entities;

public class Dog : BaseEntity
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Breed { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string Gender { get; set; }
    public int Status { get; set; }
    public DateTime RegistrationTime { get; set; }

    public string CustomerProfileId { get; set; }
    public CustomerProfile CustomerProfile { get; set; }

    public ICollection<DogDocument> DogDocuments { get; set; }

    public ICollection<DogCertificate> DogCertificates { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; }

    public ICollection<Attendance> Attendances { get; set; }

    public ICollection<TrainingReport> TrainingReports { get; set; }
}