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
                new Beast { BeastId = 1, Name = "Doctor", Species = "Hog", Temperment = "aloof, but loving", Description = "is 300+ pounds with black and pink blotch patterning & a scarred snout", Age = 15, Gender = "Male", Photo = "/../../img/pauline-bernfeld-S99OqS453go-unsplash.jpeg"},
                
                new Beast { BeastId = 2, Name = "Murna", Species = "Cow", Temperment = "very sweet. She's a total goof", Description = "is young & fit with goldeny, cream-colored fur", Age = 2, Gender = "Female", Photo = "/../../img/nighthawk-shoots-BOuggN1tMEk-unsplash.jpeg"},

                new Beast { BeastId = 3, Name = "Biddy", Species = "Hog", Temperment = "crotchety. She's recovering from some trauma, but she's a big love-dove, really", Description = "is silvery & quite fatsome", Age = 9, Gender = "Female", Photo = "/../../img/noelle-KmrmYDyiExg-unsplash.jpeg"},

                new Beast { BeastId = 4, Name = "Haystack", Species = "Hog", Temperment = "mercurial, playful, & very lazy", Description = "looks like a haystack", Age = 4, Gender = "Female", Photo = "/../../img/callum-hill-Zx6ZD3n6x4A-unsplash.jpeg"},

                new Beast { BeastId = 5, Name = "Lonely", Species = "Brown Bear", Temperment = "social & snuggly", Description = "is furry, brown, & quite large", Age = 15, Gender = "Male", Photo = "/../../img/mark-basarab-y421kXlUOQk-unsplash.jpeg"},

                new Beast { BeastId = 6, Name = "Hobnail", Species = "Sea Lion", Temperment = "unruly!", Description = "is stinky, loud, & mustachioed", Age = 8, Gender = "Male", Photo = "/../../img/taylor-wright-xFzaWaNxXSc-unsplash.jpeg"}
            );
        }

        public DbSet<Beast> Beasts { get; set; }
    }
}