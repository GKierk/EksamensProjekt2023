using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EksamensProjekt2023.Pages.User;
/// <summary>
/// Date Created: 2023-11-14 <br />
/// Author: Gabriel H. Kierkegaard <br />
/// <br />
/// 
/// A Model of a group which contains it's members and assigned leader.
/// </summary>
public class RegisterModel : PageModel
{
    private readonly UserManager<UserProfile> userManager;
    private readonly SignInManager<UserProfile> signInManager;

    public RegisterModel(UserManager<UserProfile> userManager, SignInManager<UserProfile> signInManager)
    {
        this.userManager = userManager;
        this.signInManager = signInManager;
    }

    [BindProperty]
    public Register register { get; set; }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            var userProfile = new UserProfile()
            {
                UserName = register.Email,
                Email = register.Email,
            };


            var result = await userManager.CreateAsync(userProfile, register.Password);
            if (result.Succeeded)
            {
                await signInManager.SignInAsync(userProfile, false);
                return RedirectToPage("/Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }

        return Page();
    }
}
