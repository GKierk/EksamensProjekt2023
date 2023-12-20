using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages.Groups
{
    public class AsssignGroupMembersModel : PageModel
    {
        private TastanDBContext dbContext;
        private UserManager<UserProfile> userManager;
        public List<AssignMember> assignMembers = new List<AssignMember>();


        public AsssignGroupMembersModel(TastanDBContext dbContext, UserManager<UserProfile> userManager)
        {
            this.dbContext = dbContext;

            assignMembers = userManager.Users.Select(user => new AssignMember(user)).ToList();
        }


        public void OnGet(string groupId)
        {
        }

        public IActionResult OnPost(string groupId)
        {

            foreach (var member in assignMembers)
            {
                if (member.IsMember)
                {
                    var groupMember = new GroupMember(groupId, member.UserProfile.Id);
                    dbContext.GroupMembers.Add(groupMember);
                }
            }

            dbContext.SaveChanges();

            return RedirectToPage("/Groups/ReadGroup");
        }
    }
}
