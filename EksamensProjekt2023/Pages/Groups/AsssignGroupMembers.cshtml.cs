using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages.Groups
{
    public class AsssignGroupMembersModel : PageModel
    {
        private TastanDBContext dbContext;

        public AsssignGroupMembersModel(TastanDBContext dbContext)
        {
            this.dbContext = dbContext;
            AssignMembers = new List<AssignMember>();

            foreach (var user in dbContext.Users)
            {
                AssignMembers.Add(new AssignMember(user));
            }
        }

        [BindProperty]
        public List<AssignMember> AssignMembers { get; set; }

        public void OnGet(string groupId)
        {
        }

        public IActionResult OnPost(string groupId)
        {
            for (int i = 0; i < AssignMembers.Count; i++)
            {
                if (AssignMembers[i].IsMember)
                {
                    string userId = AssignMembers[i].UserProfile.Id;
                    GroupMember groupMember = new GroupMember(groupId, userId);
                    dbContext.GroupMembers.Add(groupMember);
                }
            }

            dbContext.SaveChanges();

            return RedirectToPage("/Groups/ReadGroup");
        }
    }
}
