using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages.Groups;

public class AssignLeaderModel : PageModel
{
    private TastanDBContext dbContext;

    public AssignLeaderModel(TastanDBContext dbContext)
    {

        this.dbContext = dbContext;

    }

    [BindProperty]
    public UserProfile UserProfile { get; set; }

    [BindProperty]
    public Group Group { get; set; }


    public IActionResult OnGet(string userId, string groupId)
    {
        UserProfile = dbContext.UserProfiles.Find(userId);
        Group = dbContext.Groups.Find(groupId);
        Group.GroupLeader = UserProfile;
        dbContext.SaveChanges();
        return RedirectToPage("/Groups/ReadGroup");
    }
}
