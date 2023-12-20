using Microsoft.AspNetCore.Mvc;

namespace EksamensProjekt2023.Models;

public class AssignMember
{
    public AssignMember() { }

    public AssignMember(UserProfile userProfile)
    {
        UserProfile = userProfile;
        IsMember = false;
    }

    public UserProfile UserProfile { get; set; }
    public bool IsMember { get; set; }
}
