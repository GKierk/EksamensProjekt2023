using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages.AdminPanel;
/// <summary>
/// Date Created: 2023-12-12 <br />
/// Author: Gabriel H. Kierkegaard <br />
/// <br />
/// 
/// </summary>
public class ReadSaleModel : PageModel
{
    private TastanDBContext dBContext;

    public ReadSaleModel(TastanDBContext context)
    {
        dBContext = context;
    }

    [BindProperty]
    public UserProfile UserProfile { get; set; }

    [BindProperty]
    public List<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();

    [BindProperty]
    public Record Record { get; set; }

    [BindProperty]
    public List<Record> Records { get; set; } = new List<Record>();

    public void OnGet()
    {
        foreach (var user in dBContext.UserProfiles)
        {
            UserProfiles.Add(user);
        }

        foreach (var record in dBContext.Records)
        {
            Records.Add(record);
        }
    }

    public void OnPostUpdate()
    {
    }
}
