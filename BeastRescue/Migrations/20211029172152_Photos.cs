using Microsoft.EntityFrameworkCore.Migrations;

namespace BeastRescue.Migrations
{
    public partial class Photos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Beasts",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Beasts",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Beasts",
                columns: new[] { "BeastId", "Age", "Description", "Gender", "Name", "Photo", "Species", "Temperment" },
                values: new object[] { 1, 15, "300+ pounds, black and pink blotch patterning, scarred snout", "Male", "Doctor", "https://unsplash.com/photos/_bweKYLQbGU", "Hog", "Aloof, but loving" });

            migrationBuilder.InsertData(
                table: "Beasts",
                columns: new[] { "BeastId", "Age", "Description", "Gender", "Name", "Photo", "Species", "Temperment" },
                values: new object[] { 2, 2, "Goldeny, cream-colored fur. Slender.", "Female", "Murna", "https://unsplash.com/photos/BOuggN1tMEk", "Cow", "Very sweet; a goof" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Beasts");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Beasts");
        }
    }
}
