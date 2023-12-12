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


    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            string userId = Record.UserProfile.Id;
            UserProfile? user = dBContext.UserProfiles.Find(userId);

            if (user != null)
            {
                Record.UserProfile = user;
                dBContext.Records.Add(Record);
                dBContext.SaveChanges();
            }
        }

        return Page();
    }
}
