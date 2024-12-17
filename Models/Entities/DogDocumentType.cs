namespace Models.Entities;

public class DogDocumentType : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    
    public ICollection<DogDocument> DogDocuments { get; set; }
}