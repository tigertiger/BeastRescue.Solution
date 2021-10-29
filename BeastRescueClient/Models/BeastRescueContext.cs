using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeastRescue.Models
{
  public class BeastRescueContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Beast> Beasts { get; set; }

    public BeastRescueContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}