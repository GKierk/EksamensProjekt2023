using System.ComponentModel.DataAnnotations;

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
    public User() 
    {
        UserID = Guid.NewGuid().ToString();
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        Username = string.Empty;
        UserPassword = string.Empty;
        IsAdmin = false;
        IsLeader = false;
        IsApproved = false;
    }

    public User(string firstName, string lastName, string email, int phoneNumber, string username, string userPassword)
    {
        UserID = Guid.NewGuid().ToString();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Username = username;
        UserPassword = userPassword;
        IsAdmin = false;
        IsLeader = false;
        IsApproved = false;
    }

    [Key]
    public string UserID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public string Username { get; set; }
    public string UserPassword { get; set; }
    public bool IsAdmin { get; set; }
    public bool IsLeader { get; set; }
    public bool IsApproved { get; set; }
}