namespace Models.DTOs.Account;

public class AccountUpdateRequest
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int Gender { get; set; }
    public string ImageUrl { get; set; }
}
