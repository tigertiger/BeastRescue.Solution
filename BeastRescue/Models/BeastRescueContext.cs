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
                new Beast { BeastId = 1, Name = "Doctor", Species = "Hog", Temperment = "Aloof, but loving", Description = "300+ pounds, black and pink blotch patterning, scarred snout", Age = 15, Gender = "Male", Photo = "/../../img/pauline-bernfeld-S99OqS453go-unsplash.jpeg"},
                
                new Beast { BeastId = 2, Name = "Murna", Species = "Cow", Temperment = "Very sweet; a goof", Description = "Goldeny, cream-colored fur. Slender.", Age = 2, Gender = "Female", Photo = "/../../img/nighthawk-shoots-BOuggN1tMEk-unsplash.jpeg"},

                new Beast { BeastId = 3, Name = "Biddy", Species = "Hog", Temperment = "Crotchety; recovering from trauma; big love dove, really", Description = "Silvery, quite fatsome", Age = 9, Gender = "Female", Photo = "/../../img/noelle-KmrmYDyiExg-unsplash.jpeg"},

                new Beast { BeastId = 4, Name = "Haystack", Species = "Hog", Temperment = "Mercurial, playful, lazy", Description = "Looks like a haystack", Age = 4, Gender = "Female", Photo = "/../../img/callum-hill-Zx6ZD3n6x4A-unsplash.jpeg"},

                new Beast { BeastId = 5, Name = "Lonely", Species = "Brown Bear", Temperment = "Social & snuggly", Description = "Furry, brown, large", Age = 15, Gender = "Male", Photo = "/../../img/mark-basarab-y421kXlUOQk-unsplash.jpeg"},

                new Beast { BeastId = 6, Name = "Hobnail", Species = "Sea Lion", Temperment = "Unruly!", Description = "Stinky, loud, mustachioed", Age = 8, Gender = "Male", Photo = "/../../img/taylor-wright-xFzaWaNxXSc-unsplash.jpeg"}
            );
        }

        public DbSet<Beast> Beasts { get; set; }
    }
}