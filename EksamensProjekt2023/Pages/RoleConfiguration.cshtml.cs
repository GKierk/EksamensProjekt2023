using EksamensProjekt2023.Models;
using EksamensProjekt2023.Pages.AdminPanel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace EksamensProjekt2023.Pages
{
    [Authorize(Roles = ("Admin"))]
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
        [BindProperty]
        public List<UserRoles> UserRoles { get; set; }
        [BindProperty]
        public IdentityRole Role { get; set; }
  
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

        public IActionResult OnPost(string userId, string roleName)
        {
            Role = dbContext.Roles.SingleOrDefault(r => r.Name == roleName);
            UserProfile = dbContext.UserProfiles.Find(userId);

            if (Role != null && UserProfile != null)
            {
                var existingUserRole = dbContext.UserRoles.SingleOrDefault(ur => ur.UserId == UserProfile.Id);

                if (existingUserRole != null)
                {
                    dbContext.UserRoles.Remove(existingUserRole);
                    dbContext.SaveChanges();

                    
                    var userRole = new UserRoles
                    {
                        UserId = UserProfile.Id,
                        RoleId = Role.Id
                    };

                    dbContext.UserRoles.Add(userRole);
                    dbContext.SaveChanges();
                }
                else
                {

                    var userRole = new UserRoles
                {
                    UserId = UserProfile.Id,
                    RoleId = Role.Id
                };

                dbContext.UserRoles.Add(userRole);
                }
                dbContext.SaveChanges();

                return RedirectToPage("/RoleConfiguration");
            }
            return Page();
        }
    }
}