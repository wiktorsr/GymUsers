using Microsoft.EntityFrameworkCore;
using GymUsers.Models;

namespace GymUsers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Pass> Passes { get; set; }
    }
}
