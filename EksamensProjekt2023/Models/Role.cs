using System;


namespace EksamensProjekt2023.Models
{
    public class Role
    {
        static void Main()
        {

            Admin adminRole = new Admin
            {
                RoleID = 1,
                RoleName = "Administrator",

            };


            BoardMember boardMemberRole = new BoardMember
            {
                RoleID = 2,
                RoleName = "Board Member",

            };


            Leader leaderRole = new Leader
            {
                RoleID = 3,
                RoleName = "Leader",

            };


            Member memberRole = new Member
            {
                RoleID = 4,
                RoleName = "Member",

            };


            Console.WriteLine("Administrator Role:");
            Console.WriteLine($"Role ID: {adminRole.RoleID}");
            Console.WriteLine($"Role Name: {adminRole.RoleName}");
            Console.WriteLine();


            Console.WriteLine("Member Role:");
            Console.WriteLine($"Role ID: {boardMemberRole.RoleID}");
            Console.WriteLine($"Role Name: {boardMemberRole.RoleName}");
            Console.WriteLine();


            Console.WriteLine("Leader Role:");
            Console.WriteLine($"Role ID: {leaderRole.RoleID}");
            Console.WriteLine($"Role Name: {leaderRole.RoleName}");
            Console.WriteLine();


            Console.WriteLine("Member Role:");
            Console.WriteLine($"Role ID: {memberRole.RoleID}");
            Console.WriteLine($"Role Name: {memberRole.RoleName}");
        }
    }

    public class Admin
    {
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
        public string? SpecialPermission { get; set; }
    }

    public class BoardMember
    {
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
        public string? Committee { get; set; }
    }

    public class Leader
    {
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
        public string? TeamName { get; set; }
    }

    public class Member
    {
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
        public string? TeamName { get; set; }
    }
}
