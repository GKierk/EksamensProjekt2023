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
    private string username;
    private string password;
    private string firstName;
    private string lastName;
    private string email;
    private int phoneNumber;
    private bool isAdmin;
    private bool isLeader;
    private bool isApproved;

    public User(string username, string password, string firstName, string lastName, string email, int phoneNumber)
    {
        this.username = username;
        this.password = password;
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.phoneNumber = phoneNumber;
        isAdmin = false;
        isLeader = false;
        isApproved = false;
    }

    public string Username => username;
    public string Password => password;
    public string FirstName => firstName;
    public string LastName => lastName;
    public string Email => email;
    public int PhoneNumber => phoneNumber;

    public void SetAdmin() => isAdmin = true;
    public void SetLeader() => isLeader = true;
    public void SetApproved() => isApproved = true;
}