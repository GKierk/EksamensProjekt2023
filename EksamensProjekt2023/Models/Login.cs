using System.ComponentModel.DataAnnotations;

namespace EksamensProjekt2023.Models;
/// <summary>
/// Date Created: 2023-11-14 <br />
/// Author: Gabriel H. Kierkegaard <br />
/// <br />
/// 
/// A Model of a group which contains it's members and assigned leader.
/// </summary>
public class Login
{
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    public bool RememberMe { get; set; }
}
