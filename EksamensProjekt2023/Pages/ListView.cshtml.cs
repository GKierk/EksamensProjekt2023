using EksamensProjekt2023.Models;
using EksamensProjekt2023.Models.Roles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EksamensProjekt2023.Pages
{/// <summary>
/// Date Created: 2023-12-14 <br />
/// Author: Lasse B. Hindsberg <br />
/// <br />
/// 
/// </summary>
    public class ListViewModel : PageModel
    {
        private TastanDBContext dBContext;

        public ListViewModel(TastanDBContext context)
        {
            dBContext = context;
        }
        // Adds the string pageName to detect url later on
        [BindProperty]
        public string pageName { get; set; }
        // defines group
        [BindProperty]
        public Group Group { get; set; }
        [BindProperty]
        // makes group into a list to be used in forEach
        public List<Group> Groups { get; set; } = new List<Group>();
        [BindProperty]
        // repeated with Leader
        public Leader Leader { get; set; }
        public List<Leader> Leaders { get; set; } = new List<Leader>();
        public void OnGet()
        {
            // detects page from the URL parameters
            pageName = Request.Query["Page"];

            // Loops over data in database to be printed in the tables on the page

            /// REMEMBER TO REMOVE THE COMMENT FROM THIS PART
/*            foreach (var group in dBContext.Groups)
            {
                Groups.Add(group);
            }
            // repeat with Leader
            foreach (var leader in dBContext.Leaders)
            {
                Leaders.Add(leader);
            }
*/
        }
    }
}
