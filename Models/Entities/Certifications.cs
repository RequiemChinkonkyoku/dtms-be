namespace Models.Entities;

public class Certifications : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Status { get; set; }
    public DateTime UploadTime { get; set; }
    public string ImageUrl { get; set; }
    
    public string TrainerId { get; set; }
    public Account Trainer { get; set; }
}