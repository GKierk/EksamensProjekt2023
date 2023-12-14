//using EksamensProjekt2023.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;

//namespace EksamensProjekt2023.Pages.Groups
///// <summary>
///// Date Created: 2023-12-14 <br />
///// Author: Muhammed Tastan <br />
///// <br />
///// 
///// </summary>
//{
//    public class ReadGroupModel : PageModel
//    {
//        private TastanDBContext dBContext;

//        public ReadGroupModel(TastanDBContext context)
//        {
//            dBContext = context;
//        }

//        [BindProperty]
//        public List<Group> Groups { get; set; } = new List<Group>();

//        public void OnGet()
//        {
//            Groups = dBContext.Groups.Include(g => g.Members).ToList();
//        }
//    }
//}
