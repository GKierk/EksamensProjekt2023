using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EksamensProjekt2023.Models;
using EksamensProjekt2023.Interfaces;
using EksamensProjekt2023.Services.Interfaces;

namespace EksamensProjekt2023.Pages;
/// <summary>
/// Date Created: 2023-11-15 <br />
/// Author: Gabriel H. Kierkegaard
/// </summary>
[BindProperties]
public class TestPageModel : PageModel
{
    private IUserService userService;

    public TestPageModel(IUserService iUService)
    {
        userService = iUService;
        Users = new List<User>();
    }

    public IEnumerable<User> Users { get; private set; }

    public User? UserProfile { get; set; }

    public void OnGet()
    {
        Users = userService.GetUsers();
    }
}
