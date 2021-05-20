using App.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Car> Cars { get; set; }
        public AppDbContext(DbContextOptions options) : base(options) {}
    }
}