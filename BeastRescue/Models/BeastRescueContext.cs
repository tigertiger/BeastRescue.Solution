using Microsoft.EntityFrameworkCore;

namespace BeastRescue.Models
{
    public class BeastRescueContext : DbContext
    {
        public BeastRescueContext(DbContextOptions<BeastRescueContext> options)
            : base(options)
        {
        }

        public DbSet<Beast> Beasts { get; set; }
    }
}