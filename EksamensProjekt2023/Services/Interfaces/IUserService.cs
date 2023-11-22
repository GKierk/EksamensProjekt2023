using EksamensProjekt2023.Models;

namespace EksamensProjekt2023.Services.Interfaces;
/// <summary>
/// Date Created: 2023-11-15 <br />
/// Author: Gabriel H. Kierkegaard
/// </summary>
public interface IUserService
{
    public IEnumerable<UserProfile> GetUsers();
}
