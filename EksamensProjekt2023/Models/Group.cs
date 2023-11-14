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
    private string groupName;
    private List<User> members;
    private User? groupLeader;

    public Group(string groupName)
    {
        this.groupName = groupName;
        members = new List<User>();
    }

    public string GroupName => groupName;
    public List<User> Members => members;
    public User? GroupLeader => groupLeader;

    public void AssignMember(User user) => members.Add(user);
    public void RemoveMember(User user) => members.Remove(user);
    public void AssignLeader(User user) => groupLeader = user;
    public void RemoveLeader() => groupLeader = null;
}
