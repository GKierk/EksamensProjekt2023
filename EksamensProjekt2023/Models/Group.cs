using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EksamensProjekt2023.Models
{
    /// <summary>
    /// Date Created: 2023-11-14 <br />
    /// Author: Gabriel H. Kierkegaard <br />
    /// <br />
    /// A Model of a group which contains its members and assigned leader.
    /// </summary>
    public class Group
    {
        public Group()
        {
            Id = Guid.NewGuid().ToString();
            GroupName = string.Empty;
        }

        public Group(string groupName, UserProfile groupLeader)
        {
            Id = Guid.NewGuid().ToString();
            GroupName = groupName;
            GroupLeader = groupLeader;
        }

        [Key]
        public string Id { get; set; }

        public string GroupName { get; set; }

        [ForeignKey("GroupLeaderId")]
        public virtual UserProfile GroupLeader { get; set; }
    }
}
