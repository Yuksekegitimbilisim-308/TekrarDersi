using Microsoft.EntityFrameworkCore;
using TekrarDersi.Entities;

namespace TekrarDersi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {}
        public DbSet<User> Users{ get; set; }
    }
}
