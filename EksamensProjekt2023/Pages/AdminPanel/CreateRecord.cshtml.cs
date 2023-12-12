using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EksamensProjekt2023.Models;

namespace EksamensProjekt2023.Pages.AdminPanel;

/// <summary>
/// Date Created: 2023-12-11 <br />
/// Author: Gabriel H. Kierkegaard <br />
/// <br />
/// 
/// </summary>
public class CreateRecordModel : PageModel
{
    private TastanDBContext dBContext;

    public CreateRecordModel(TastanDBContext context)
    {
        Record = new Record();
        dBContext = context;
    }

    [BindProperty]
    public Record Record { get; set; }

    public void OnGet(string Id)
    {
        UserProfile userProfile = dBContext.UserProfiles.Find(Id);
        Record.UserProfile = userProfile;
    }

    public IActionResult OnPost(string Id)
    {
        UserProfile userProfile = dBContext.UserProfiles.Find(Id);

        if (userProfile != null)
        {
            Record.UserProfile = userProfile;
            dBContext.Records.Add(Record);
            dBContext.SaveChanges();

            return RedirectToPage("/AdminPanel/ReadSale");
        }

        return Page();
    }
}
