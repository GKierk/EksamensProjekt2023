using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages
{
    public class MembersModel : PageModel
    {
        private TastanDBContext dbContext; 

        public MembersModel(TastanDBContext context)
        {
            dbContext = context;
        }
        [BindProperty]
        public Group group { get; set; }
        [BindProperty]
        public List<Group> groups { get; set; } = new List<Group>();

        public void OnGet()
        {
            foreach (var group in dbContext.Groups)
            {
                groups.Add(group);
            }
        }
    }
}
