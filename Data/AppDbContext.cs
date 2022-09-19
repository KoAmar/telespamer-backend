using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using telespamer_backend.Models;

namespace telespamer_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
            //Database.Migrate();
        }
        public DbSet<User>? Users { get; set; }
        public DbSet<TeleBot>? TeleBots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "Admin", Email = "admin@admin.ad", Password = "admin", CreationDate = DateTime.MinValue });
        }
    }
}
