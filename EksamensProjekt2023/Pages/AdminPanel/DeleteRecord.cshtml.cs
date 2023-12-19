using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EksamensProjekt2023.Pages.AdminPanel;
// TODO: Finish DeleteSale
[Authorize(Roles = ("Admin"))]
public class DeleteSaleModel : PageModel
{
    private TastanDBContext dBContext;

    public DeleteSaleModel(TastanDBContext context)
    {
        dBContext = context;
    }

    public IActionResult OnGet(string RecordID)
    {
        var recordToDelete = dBContext.Records.Find(RecordID);

        if (recordToDelete != null)
        {
            dBContext.Remove(recordToDelete);
            dBContext.SaveChanges();
        }

        return RedirectToPage("/AdminPanel/ReadSale");
    }
}
