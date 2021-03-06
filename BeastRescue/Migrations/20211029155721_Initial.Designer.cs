// <auto-generated />
using BeastRescue.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeastRescue.Migrations
{
    [DbContext(typeof(BeastRescueContext))]
    [Migration("20211029155721_Initial")]
    partial class Initial
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

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Temperment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BeastId");

                    b.ToTable("Beasts");
                });
#pragma warning restore 612, 618
        }
    }
}
