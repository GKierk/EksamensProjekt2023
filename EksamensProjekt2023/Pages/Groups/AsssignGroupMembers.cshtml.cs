using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages.Groups
{
    public class AsssignGroupMembersModel : PageModel
    {
        private TastanDBContext dbContext;
        public readonly List<AssignMember> assignMembers;

        public AsssignGroupMembersModel(TastanDBContext dbContext)
        {
            this.dbContext = dbContext;


            if (assignMembers == null)
            {
                assignMembers = new List<AssignMember>();

                foreach (var member in dbContext.Users)
                {
                    assignMembers.Add(new AssignMember(member));
                }
            }
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
