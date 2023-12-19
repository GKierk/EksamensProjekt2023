using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EksamensProjekt2023.Models;

[PrimaryKey(nameof(UserProfileId), nameof(GroupId))]
public class GroupMember
{
    public GroupMember() {}

    public GroupMember(string groupId, UserProfile userProfile)
    {
        GroupId = groupId;
        UserProfile = userProfile;
    }

    [ForeignKey("GroupId")]
    public string GroupId { get; set; }

    public virtual Group Group { get; set; }

    [ForeignKey("UserProfileId")]
    public string UserProfileId { get; set; }

    public virtual UserProfile UserProfile { get; set; }
}
