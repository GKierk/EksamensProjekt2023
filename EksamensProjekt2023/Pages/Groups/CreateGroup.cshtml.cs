using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages.Groups
/// <summary>
/// Date Created: 2023-12-14 <br />
/// Author: Muhammed Tastan <br />
/// <br />
/// 
/// </summary>
{
    public class CreateGroupModel : PageModel
    {
        private TastanDBContext dbContext;

        public CreateGroupModel(TastanDBContext context)
        {
            Group = new Group();
            dbContext = context;
            
        }

        [BindProperty]
        public Group Group { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                dbContext.Groups.Add(Group);
                dbContext.SaveChanges();
                return RedirectToPage("/AdminPanel/ReadGroup");
            }

            return Page();
        }
    }
}
