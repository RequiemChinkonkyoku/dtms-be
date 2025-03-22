namespace Models.Entities;

public class LegalDocument : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Status { get; set; }
    public DateTime UploadTime { get; set; }
    public string ImageUrl { get; set; }
    
    public string CustomerId { get; set; }
    public Account Account { get; set; }
}