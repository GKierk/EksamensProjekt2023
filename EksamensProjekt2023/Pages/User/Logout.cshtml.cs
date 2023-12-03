using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages.User;
/// <summary>
/// Date Created: 2023-11-14 <br />
/// Author: Gabriel H. Kierkegaard <br />
/// <br />
/// 
/// A Model of a group which contains it's members and assigned leader.
/// </summary>
public class LogoutModel : PageModel
{
    private readonly SignInManager<UserProfile> signInManager;

    public LogoutModel(SignInManager<UserProfile> signInManager)
    {
        this.signInManager = signInManager;   
    }

    public void OnGet()
    {
    }

    public IActionResult OnPostLogout()
    {
        signInManager.SignOutAsync();
        return RedirectToPage("/User/Login");
    }
}
