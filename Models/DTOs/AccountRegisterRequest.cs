using System.ComponentModel.DataAnnotations;

namespace Models.DTOs;

public class AccountRegisterRequest
{
    [Required(ErrorMessage = "Username is required.")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", 
        ErrorMessage = "Password must have at least 8 characters, including 1 uppercase, 1 lowercase, 1 special character, and 1 number.")]
    public string Password { get; set; }
    
    [Required]
    public int? ProfileType { get; set; } 
}