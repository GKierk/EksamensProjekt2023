using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EksamensProjekt2023.Pages.Groups
/// <summary>
/// Date Created: 2023-12-14 <br />
/// Author: Muhammed Tastan <br />
/// <br />
/// 
/// </summary>
{
    public class ReadGroupModel : PageModel
    {
        private TastanDBContext dBContext;

        public ReadGroupModel(TastanDBContext context, UserManager<UserProfile> userManager)
        {
            dBContext = context;
            this.userManager = userManager;

            var userRoles = dBContext.UserRoles.ToList();
            var usersInDb = dBContext.UserProfiles.ToList();
            var role = dBContext.Roles.FirstOrDefault(r => r.Name == "Leader");

            foreach (var user in usersInDb)
            {
                foreach (var ur in userRoles)
                {
                    if (user.Id == ur.UserId && ur.RoleId == role.Id)
                    {
                        UserProfiles.Add(user);
                    }
                }
            }
        }

        [BindProperty]
        public List<Group> Groups { get; set; } = new List<Group>();

        [BindProperty]
        public List<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();

        [BindProperty]
        public List<GroupMember> GroupMembers { get; set; } = new List<GroupMember>();

        public void OnGet()
        {
            Groups = dBContext.Groups.ToList();
            GroupMembers = dBContext.GroupMembers.ToList();
        }
    }
}
