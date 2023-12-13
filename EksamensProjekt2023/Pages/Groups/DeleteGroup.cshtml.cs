using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EksamensProjekt2023.Pages.Groups
/// <summary>
/// Date Created: 2023-12-14 <br />
/// Author: Muhammed Tastan <br />
/// <br />
/// 
/// </summary>
{
    public class DeleteGroupModel : PageModel
    {
        private TastanDBContext dBContext;

        public DeleteGroupModel(TastanDBContext context)
        {
            dBContext = context;
        }

        [BindProperty]
        public Group Group { get; set; }

        public void OnGet(string GroupID)
        {
            Group = dBContext.Groups.Include(g => g.Members).FirstOrDefault(g => g.GroupID == GroupID);
        }

        public IActionResult OnPost()
        {
            if (Group != null)
            {
                dBContext.Groups.Remove(Group);
                dBContext.SaveChanges();
                return RedirectToPage("/AdminPanel/ReadGroup");
            }

            return Page();
        }
    }
}
