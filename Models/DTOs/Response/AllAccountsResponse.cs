namespace Models.DTOs.Response;

public class AllAccountsResponse
{
    public string Id { get; set; }
    public DateTimeOffset CreatedTime { get; set; }
    public DateTimeOffset LastUpdatedTime { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public int Status { get; set; }
    public int? ProfileType { get; set; }
    
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
}