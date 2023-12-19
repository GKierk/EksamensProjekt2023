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
            dbContext = context;
            Group = new Group();
            GroupName = string.Empty;
        }

        [BindProperty]
        public Group Group { get; set; }

        public string GroupName { get; set; }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                dbContext.Groups.Add(Group);
                dbContext.SaveChanges();
                return RedirectToPage("/Groups/ReadGroup");
            }

            return Page();
        }
    }
}
