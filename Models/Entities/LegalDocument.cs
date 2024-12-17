namespace Models.Entities;

public class LegalDocument : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Status { get; set; }
    public DateTime UploadTime { get; set; }
    public string ImageUrl { get; set; }
    
    public int CustomerProfileId { get; set; }
    public CustomerProfile CustomerProfile { get; set; }
}