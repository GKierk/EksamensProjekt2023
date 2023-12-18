using EksamensProjekt2023.Models;
using EksamensProjekt2023.Pages.AdminPanel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EksamensProjekt2023.Pages
{
    public class RoleConfigurationModel : PageModel
    {
        private TastanDBContext dbContext;

        public RoleConfigurationModel(TastanDBContext context)
        {
            dbContext = context;
        }
        [BindProperty]
        public UserProfile UserProfile { get; set; }
        [BindProperty]
        public List<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();

        /* Needs to be able to:
         * Import roles from Database
         * Based on the input fields on the page, assign a new role to the user
         * 
         */
        public void OnGet()
        {
            foreach (var user in dbContext.UserProfiles)
            {
                UserProfiles.Add(user);
            }
        }
    }
}
