using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EksamensProjekt2023.Pages.Groups;

public class AssignMembersModel : PageModel
{
    private TastanDBContext dbContext;

    public AssignMembersModel(TastanDBContext dbContext)
    {
        this.dbContext = dbContext;
        UserProfiles = dbContext.Users;
        AssignMembers = new List<AssignMember>();

        foreach (var user in UserProfiles)
        {
            //AssignMember member = new AssignMember(user);
            //AssignMembers.Add(member);

            AssignMembers.Add(new AssignMember { UserProfile = user, IsMember = false });
        }
    }

    [BindProperty]
    public Group Group { get; set; }

    [BindProperty]
    public IEnumerable<UserProfile> UserProfiles { get; set; }

    [BindProperty]
    public IdentityRole Role { get; set; }

    [BindProperty]
    public UserRoles UserRoles { get; set; }

    [BindProperty]
    public List<AssignMember> AssignMembers { get; set; }

    [BindProperty]
    public List<GroupMember> GroupMembers { get; set; }

    public void OnGet(string groupId)
    {
        Group = dbContext.Groups.Find(groupId);
        Role = dbContext.Roles.FirstOrDefault(r => r.Name == "Leader");
    }

    public void OnPost(string groupId)
    {
        foreach (var member in AssignMembers)
        {
            if (member.IsMember)
            {
                dbContext.GroupMembers.Add(new GroupMember(groupId, member.UserProfile));
            }
        }

        dbContext.SaveChanges();

        //return RedirectToPage("/Groups/ReadGroup");
    }
}
