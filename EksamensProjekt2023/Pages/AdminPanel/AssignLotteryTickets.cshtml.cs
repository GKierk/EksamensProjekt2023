using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EksamensProjekt2023.Pages.AdminPanel;
/// <summary>
/// Date Created: 2023-12-12 <br />
/// Author: Gabriel H. Kierkegaard <br />
/// <br />
/// 
/// </summary>
///
[Authorize(Roles = ("Admin"))]
public class AssignLotteryTicketsModel : PageModel
{
    private TastanDBContext dBContext;

    public AssignLotteryTicketsModel(TastanDBContext context)
    {
        dBContext = context;
    }

    [BindProperty]
    public Record Record { get; set; }

    public void OnGet(string RecordID)
    {
        Record = dBContext.Records.Find(RecordID);
    }

    public IActionResult OnPost(string RecordID)
    {
        Record updateRecord = dBContext.Records.Find(RecordID);

        if (updateRecord != null)
        {
            updateRecord.AmountGiven = Record.AmountGiven;
            dBContext.SaveChanges();

            return RedirectToPage("/AdminPanel/ReadSale");
        }

        return Page();
    }
}
