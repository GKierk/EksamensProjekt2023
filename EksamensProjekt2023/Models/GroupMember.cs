using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EksamensProjekt2023.Models;

public class GroupMember
{
    public GroupMember() 
    {
        Id = Guid.NewGuid().ToString();
    }

    public GroupMember(string groupId, string userProfileId) : this()
    {
        GroupId = groupId;
        UserProfileId = userProfileId;
    }

    public string Id { get; set; }

    [ForeignKey("GroupId")]
    public string GroupId { get; set; }

    public virtual Group? Group { get; set; }

    [ForeignKey("UserProfileId")]
    public string UserProfileId { get; set; }

    public virtual UserProfile? UserProfile { get; set; }
}
