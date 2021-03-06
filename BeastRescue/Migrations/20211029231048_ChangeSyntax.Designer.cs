// <auto-generated />
using BeastRescue.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeastRescue.Migrations
{
    [DbContext(typeof(BeastRescueContext))]
    [Migration("20211029231048_ChangeSyntax")]
    partial class ChangeSyntax
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BeastRescue.Beast", b =>
                {
                    b.Property<int>("BeastId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Photo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Temperment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BeastId");

                    b.ToTable("Beasts");

                    b.HasData(
                        new
                        {
                            BeastId = 1,
                            Age = 15,
                            Description = "is 300+ pounds with black and pink blotch patterning & a scarred snout",
                            Gender = "Male",
                            Name = "Doctor",
                            Photo = "/../../img/pauline-bernfeld-S99OqS453go-unsplash.jpeg",
                            Species = "Hog",
                            Temperment = "aloof, but loving"
                        },
                        new
                        {
                            BeastId = 2,
                            Age = 2,
                            Description = "is young & fit with goldeny, cream-colored fur",
                            Gender = "Female",
                            Name = "Murna",
                            Photo = "/../../img/nighthawk-shoots-BOuggN1tMEk-unsplash.jpeg",
                            Species = "Cow",
                            Temperment = "very sweet. She's a total goof"
                        },
                        new
                        {
                            BeastId = 3,
                            Age = 9,
                            Description = "is silvery & quite fatsome",
                            Gender = "Female",
                            Name = "Biddy",
                            Photo = "/../../img/noelle-KmrmYDyiExg-unsplash.jpeg",
                            Species = "Hog",
                            Temperment = "crotchety. She's recovering from some trauma, but she's a big love-dove, really"
                        },
                        new
                        {
                            BeastId = 4,
                            Age = 4,
                            Description = "looks like a haystack",
                            Gender = "Female",
                            Name = "Haystack",
                            Photo = "/../../img/callum-hill-Zx6ZD3n6x4A-unsplash.jpeg",
                            Species = "Hog",
                            Temperment = "mercurial, playful, & very lazy"
                        },
                        new
                        {
                            BeastId = 5,
                            Age = 15,
                            Description = "is furry, brown, & quite large",
                            Gender = "Male",
                            Name = "Lonely",
                            Photo = "/../../img/mark-basarab-y421kXlUOQk-unsplash.jpeg",
                            Species = "Brown Bear",
                            Temperment = "social & snuggly"
                        },
                        new
                        {
                            BeastId = 6,
                            Age = 8,
                            Description = "stinky, loud, & mustachioed",
                            Gender = "Male",
                            Name = "Hobnail",
                            Photo = "/../../img/taylor-wright-xFzaWaNxXSc-unsplash.jpeg",
                            Species = "Sea Lion",
                            Temperment = "unruly!"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
