using App.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Car> Cars { get; set; }
        public AppDbContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Car>().HasData(
                new Car { Id = 1, Make = "Ford", Model = "Focus", Type = "Sedan", Color = "Grey", Year = 2008 }
                );

            builder.Entity<User>().HasData(
                new User { Id = 1, Name = "Andy Ford"}
                );

            base.OnModelCreating(builder);
        }
    }
}