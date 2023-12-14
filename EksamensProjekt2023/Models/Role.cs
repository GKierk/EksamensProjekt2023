using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EksamensProjekt2023.Models;
/// <summary>
/// Date Created: 2023-12-14 <br />
/// Author: Gabriel H. Kierkegaard <br />
/// <br />
/// 
/// </summary>
public class Role : IdentityRole
{
    [ForeignKey("Id")]
    public virtual UserProfile UserProfile { get; set; }
}
