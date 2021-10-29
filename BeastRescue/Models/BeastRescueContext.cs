using Microsoft.EntityFrameworkCore;

namespace BeastRescue.Models
{
    public class BeastRescueContext : DbContext
    {
        public BeastRescueContext(DbContextOptions<BeastRescueContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Beast>()
            .HasData(
                new Beast { BeastId = 1, Name = "Doctor", Species = "Hog", Temperment = "Aloof, but loving", Description = "300+ pounds, black and pink blotch patterning, scarred snout", Age = 15, Gender = "Male", Photo = "https://unsplash.com/photos/S99OqS453go"},
                
                new Beast { BeastId = 2, Name = "Murna", Species = "Cow", Temperment = "Very sweet; a goof", Description = "Goldeny, cream-colored fur. Slender.", Age = 2, Gender = "Female", Photo = "https://unsplash.com/photos/BOuggN1tMEk"}
            );
        }

        public DbSet<Beast> Beasts { get; set; }
    }
}