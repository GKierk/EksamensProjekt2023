using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages.AdminPanel;
/// <summary>
/// Date Created: 2023-12-12 <br />
/// Author: Gabriel H. Kierkegaard <br />
/// <br />
/// 
/// </summary>
[Authorize(Roles = ("Admin"))]
public class UpdateSaleModel : PageModel
{
    private TastanDBContext dBContext;

    public UpdateSaleModel(TastanDBContext context)
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
            updateRecord.AmountSold = Record.AmountSold;
            updateRecord.MobilePayAmount = Record.MobilePayAmount;
            dBContext.SaveChanges();
            
            return RedirectToPage("/AdminPanel/ReadSale");
        }

        return Page();
    }
}
