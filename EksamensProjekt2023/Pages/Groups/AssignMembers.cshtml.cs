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
        UserProfiles = dbContext.Users.ToList();
        AssignMembers = new List<AssignMember>();

        foreach (var user in UserProfiles)
        {
            AssignMembers.Add(new AssignMember { UserProfile = user, IsMember = false });
        }
    }

    [BindProperty]
    public Group Group { get; set; }

    [BindProperty]
    public GroupMember GroupMember { get; set; }

    [BindProperty]
    public UserProfile UserProfile { get; set; }

    [BindProperty]
    public List<UserProfile> UserProfiles { get; set; }

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
    }

    public IActionResult OnPost(string groupId)
    {
        foreach (var member in AssignMembers)
        {
            GroupMember newGroupMember = new GroupMember { GroupId = groupId, UserProfileId = member.UserProfile.Id};
            
            if (member.IsMember)
            {
            }
        }

        return RedirectToPage("/Groups/ReadGroup");
    }

}
