namespace Models.DTOs.Response;

public class AllAccountsResponse
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ImageUrl { get; set; }
    public int Status { get; set; }
    public DateTime RegistrationTime { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Gender { get; set; }
    public int MembershipPoints { get; set; }
    
    public string RoleId { get; set; }
    
    public string MembershipId { get; set; }
}