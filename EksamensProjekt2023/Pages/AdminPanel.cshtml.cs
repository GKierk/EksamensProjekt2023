using EksamensProjekt2023.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages
{
    public class AdminPanelModel : PageModel
    {
        private TastanDBContext dbContext;

        public AdminPanelModel(TastanDBContext context)
        {
            dbContext = context;
        }
        [BindProperty]
        public Group group { get; set; }
        [BindProperty]
        public List<Group> groups { get; set; } = new List<Group>();

        /* somehow insert Leader list in here and make it do the same as the groups
         * 
         * 
         * 
         */
        public void OnGet()
        {
            foreach (var group in dbContext.Groups) {
            groups.Add(group);
            }
        }
    }
}
