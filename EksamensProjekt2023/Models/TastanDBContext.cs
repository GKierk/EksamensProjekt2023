using EksamensProjekt2023.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EksamensProjekt2023.Models
{
    public class TastanDBContext : IdentityDbContext<UserProfile>
    {
        public TastanDBContext(DbContextOptions<TastanDBContext> options) : base(options) 
        {
            
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Group> Groups { get; set; }

    }
}
