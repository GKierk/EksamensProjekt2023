using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EksamensProjekt2023.Models;

namespace EksamensProjekt2023.Pages
{
    public class RegisterModel : PageModel
    {
        public User UserProfile { get; set; }
        public void OnGet()
        {
            UserProfile = new User();
        }
    }
}
