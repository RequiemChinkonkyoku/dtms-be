namespace Models.Entities;

public class DogDocument : BaseEntity
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public int Status { get; set; }
    public DateOnly IssueDate { get; set; }
    public DateTime UploadTime { get; set; }
    
    public string DogId { get; set; }
    public Dog Dog { get; set; }
    
    public string DogDocumentTypeId { get; set; }
    public DogDocumentType DogDocumentType { get; set; }
}