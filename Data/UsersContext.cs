using Microsoft.EntityFrameworkCore;
using telespamer_backend.Models;

namespace telespamer_backend.Data
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        {
            //Database.EnsureCreated();
            //Database.Migrate();
        }
        public DbSet<User>? Users { get; set; }
    }
}
