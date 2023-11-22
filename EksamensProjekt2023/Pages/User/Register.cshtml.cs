using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EksamensProjekt2023.Pages.User
{
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
}
