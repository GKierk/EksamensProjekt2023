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
public class LoginModel : PageModel
{
    private readonly SignInManager<UserProfile> signInManager;

    public LoginModel(SignInManager<UserProfile> signInManager)
    {
        this.signInManager = signInManager;
    }

    [BindProperty]
    public Login login { get; set; }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync(string returnUrl = null)
    {
        if (ModelState.IsValid)
        {
            var result = await signInManager.PasswordSignInAsync(login.Email, login.Password, login.RememberMe, false);
            if (result.Succeeded)
            {
                if (returnUrl == null || returnUrl == "/")
                {
                    return RedirectToPage("/Index");
                }
                else
                {
                    return RedirectToPage(returnUrl);
                }
            }

            ModelState.AddModelError("", "Username or Password are incorrect.");
        }

        return Page();
    }
}
