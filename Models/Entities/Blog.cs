namespace Models.Entities;

public class Blog : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; }
    public int Status { get; set; }
    public DateTime TimePublished { get; set; }
    
    public string StaffProfileId { get; set; }
    public StaffProfile StaffProfile { get; set; }
}