namespace Models.Entities;

public class Dog : BaseEntity
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public int Gender { get; set; }
    public int Status { get; set; }
    public DateTime RegistrationTime { get; set; }

    public string DogBreedId { get; set; }
    public DogBreed DogBreed { get; set; }

    public ICollection<DogDocument> DogDocuments { get; set; }

    public ICollection<DogCertificate> DogCertificates { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; }

    public ICollection<Attendance> Attendances { get; set; }

    public ICollection<TrainingReport> TrainingReports { get; set; }

    public ICollection<DogOwnership> DogOwnerships { get; set; }

    public ICollection<PreTest> PreTests { get; set; }
}