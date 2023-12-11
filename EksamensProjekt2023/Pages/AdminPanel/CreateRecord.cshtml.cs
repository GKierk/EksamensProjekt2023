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
    private TastanDBContext dBcontext;

    public CreateRecordModel(TastanDBContext context)
    {
        Record = new Record();
        dBcontext = context;
    }

    [BindProperty]
    public Record Record {  get; set; }


    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            string userId = Record.UserProfile.Id;
            UserProfile? user = dBcontext.UserProfiles.Find(userId);

            if (user != null)
            {
                Record.UserProfile = user;
                dBcontext.Records.Add(Record);
                dBcontext.SaveChanges();
            }
        }

        return Page();
    }
}
