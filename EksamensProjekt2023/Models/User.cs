namespace EksamensProjekt2023.Models;
/// <summary>
/// Date Created: 2023-11-14 <br />
/// Author: Muhammed Tastan <br />
/// Date Edited: 2023-11-14 <br />
/// Co-Author: Gabriel H. Kierkegaard <br />
/// <br />
/// 
/// A simple user model.
/// </summary>
public class User
{
    public int UserID { get; set; }
    public string? Username { get; set; }
    public string? UserPassword { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public int PhoneNumber { get; set; }
    public bool IsAdmin { get; set; }
    public bool IsLeader { get; set; }
    public bool IsApproved { get; set; }


    public void SetAdmin() => IsAdmin = true;
    public void SetLeader() => IsLeader = true;
    public void SetApproved() => IsApproved = true;
}