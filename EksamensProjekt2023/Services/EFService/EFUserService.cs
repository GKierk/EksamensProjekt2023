using EksamensProjekt2023.Models;
using EksamensProjekt2023.Services.Interfaces;

namespace EksamensProjekt2023.Services.EFService;
/// <summary>
/// Date Created: 2023-11-15
/// Author: Gabriel H. Kierkegaard
/// </summary>
public class EFUserService : IUserService
{
    private List<UserProfile>? UserProfiles;
    private TastanDBContext dBContext;

    public EFUserService(TastanDBContext context)
    {
        dBContext = context;
    }

    public IEnumerable<UserProfile> GetUsers()
    {
        return dBContext.UserProfiles.ToList();
    }
}
