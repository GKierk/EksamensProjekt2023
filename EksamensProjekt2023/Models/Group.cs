using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EksamensProjekt2023.Models;
/// <summary>
/// Date Created: 2023-11-14 <br />
/// Author: Gabriel H. Kierkegaard <br />
/// <br />
/// 
/// A Model of a group which contains it's members and assigned leader.
/// </summary>
public class Group
{
    public Group()
    {
        GroupID = Guid.NewGuid().ToString();
        Members = new List<User>();
        GroupName = string.Empty;
    }

    public Group(string groupName, User groupLeader)
    {
        GroupID = Guid.NewGuid().ToString();
        Members = new List<User>();
        GroupName = groupName;
        GroupLeader = groupLeader;
    }

    [Key]
    public string GroupID { get; set; }
    public string GroupName { get; set; }
    public List<User> Members { get; set; }
    [ForeignKey("UserID")]
    public virtual User? GroupLeader { get; set; }
}