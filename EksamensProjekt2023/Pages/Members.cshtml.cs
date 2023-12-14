using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages
{
    public class MembersModel : PageModel
    {
        [BindProperty]
        public string pageName { get; set; }
        public void OnGet()
        {
            pageName = Request.Query["Page"];
        }
    }
}
