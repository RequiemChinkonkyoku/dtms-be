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
    
    public int CustomerProfileId { get; set; }
    public CustomerProfile CustomerProfile { get; set; }
    
    public ICollection<DogDocument> DogDocuments { get; set; }
}