﻿// <auto-generated />
using BeastRescue.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeastRescue.Migrations
{
    [DbContext(typeof(BeastRescueContext))]
    [Migration("20211029212001_MoreSeeds")]
    partial class MoreSeeds
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
                            Description = "300+ pounds, black and pink blotch patterning, scarred snout",
                            Gender = "Male",
                            Name = "Doctor",
                            Photo = "/../../img/pauline-bernfeld-S99OqS453go-unsplash.jpeg",
                            Species = "Hog",
                            Temperment = "Aloof, but loving"
                        },
                        new
                        {
                            BeastId = 2,
                            Age = 2,
                            Description = "Goldeny, cream-colored fur. Slender.",
                            Gender = "Female",
                            Name = "Murna",
                            Photo = "/../../img/nighthawk-shoots-BOuggN1tMEk-unsplash.jpeg",
                            Species = "Cow",
                            Temperment = "Very sweet; a goof"
                        },
                        new
                        {
                            BeastId = 3,
                            Age = 9,
                            Description = "Silvery, quite fatsome",
                            Gender = "Female",
                            Name = "Biddy",
                            Photo = "/../../img/noelle-KmrmYDyiExg-unsplash.jpeg",
                            Species = "Hog",
                            Temperment = "Crotchety; recovering from trauma; big love dove, really"
                        },
                        new
                        {
                            BeastId = 4,
                            Age = 4,
                            Description = "Looks like a haystack",
                            Gender = "Female",
                            Name = "Haystack",
                            Photo = "/../../img/callum-hill-Zx6ZD3n6x4A-unsplash.jpeg",
                            Species = "Hog",
                            Temperment = "Mercurial, playful, lazy"
                        },
                        new
                        {
                            BeastId = 5,
                            Age = 15,
                            Description = "Furry, brown, large",
                            Gender = "Male",
                            Name = "Lonely",
                            Photo = "/../../img/mark-basarab-y421kXlUOQk-unsplash.jpeg",
                            Species = "Brown Bear",
                            Temperment = "Social & snuggly"
                        },
                        new
                        {
                            BeastId = 6,
                            Age = 8,
                            Description = "Stinky, loud, mustachioed",
                            Gender = "Male",
                            Name = "Hobnail",
                            Photo = "/../../img/taylor-wright-xFzaWaNxXSc-unsplash.jpeg",
                            Species = "Sea Lion",
                            Temperment = "Unruly!"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}