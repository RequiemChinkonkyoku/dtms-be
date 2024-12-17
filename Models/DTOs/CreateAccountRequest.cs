namespace Models.DTOs;

public class CreateAccountRequest
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ImageUrl { get; set; }
    public int Status { get; set; }
    public DateTime RegistrationTime { get; set; }
}