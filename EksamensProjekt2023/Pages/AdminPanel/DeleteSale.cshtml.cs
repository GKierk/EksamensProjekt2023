using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages.AdminPanel;
// TODO: Finish DeleteSale
[Authorize(Roles = ("Admin"))]
public class DeleteSaleModel : PageModel
{
    public void OnGet()
    {
    }
}
