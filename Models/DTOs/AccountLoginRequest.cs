using System.ComponentModel.DataAnnotations;

namespace Models.DTOs;

public class AccountLoginRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}