using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EksamensProjekt2023.Models;

[PrimaryKey(nameof(FullName), nameof(GroupName))]
public class GroupMember
{
    [ForeignKey("FullName")]
    public string FullName { get; set; }

    [ForeignKey("GroupName")]
    public string GroupName { get; set; }
}
