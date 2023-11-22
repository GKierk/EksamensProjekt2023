using System.ComponentModel.DataAnnotations;

namespace EksamensProjekt2023.Models;

public class Register
{
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Passwords doesn't match")]
    public string ConfirmPassword { get; set; }
}
