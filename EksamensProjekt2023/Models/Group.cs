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
        Members = new List<User>();
    }

    public int GroupID { get; set; }
    public string? GroupName { get; set; }
    public List<User> Members { get; set; }
    public User? GroupLeader { get; set; }

    public void AssignMember(User user) => Members.Add(user);
    public void RemoveMember(User user) => Members.Remove(user);
    public void AssignLeader(User user) => GroupLeader = user;
    public void RemoveLeader() => GroupLeader = null;
}