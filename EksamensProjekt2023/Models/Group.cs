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
        Members = new List<UserProfile>();
        GroupName = string.Empty;
    }

    public Group(string groupName, UserProfile groupLeader)
    {
        GroupID = Guid.NewGuid().ToString();
        Members = new List<UserProfile>();
        GroupName = groupName;
        GroupLeader = groupLeader;
    }

    [Key]
    public string GroupID { get; set; }
    public string GroupName { get; set; }
    public List<UserProfile> Members { get; set; }
    [ForeignKey("Id")]
    public virtual UserProfile? GroupLeader { get; set; }
}