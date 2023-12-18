using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EksamensProjekt2023.Models;
/// <summary>
/// Date Created: 2023-11-14 <br />
/// Author: Muhammed Tastan <br />
/// Date Edited: 2023-11-14 <br />
/// Co-Author: Gabriel H. Kierkegaard <br />
/// <br />
/// 
/// A simple user model.
/// </summary>
public class UserProfile : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName => FirstName + " " + LastName;
}