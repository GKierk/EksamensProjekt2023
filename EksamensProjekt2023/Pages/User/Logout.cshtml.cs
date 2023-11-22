using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages.User;

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
