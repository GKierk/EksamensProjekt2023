using EksamensProjekt2023.Models;
using Microsoft.EntityFrameworkCore;

namespace EksamensProjekt2023.Services
{
    public class TastanDBContext : DbContext
    {
        public TastanDBContext(DbContextOptions<TastanDBContext> options) : base(options) 
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }

    }
}
