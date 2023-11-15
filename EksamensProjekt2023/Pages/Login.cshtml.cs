using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EksamensProjekt2023.Pages;
/// <summary>
/// Date Created: 2023-11-14 <br />
/// Author: Gabriel H. Kierkegaard <br />
/// </summary>
[BindProperties]
public class LoginModel : PageModel
{
    [Display(Name = "Username: ")]
    [Required(ErrorMessage = "Username is required to login")]
    public string? Username { get; set; }

    [Display(Name = "Password")]
    [Required(ErrorMessage = "Password is required to login")]
    public string? Password { get; set; }

    public void OnGet()
    {
    }

    public void OnPostLogin()
    {
        
    }
}
