using System.ComponentModel.DataAnnotations;

namespace Store.Service.Services.User_Service.Dtos;

public class LoginDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}