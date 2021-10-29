using Microsoft.EntityFrameworkCore.Migrations;

namespace BeastRescue.Migrations
{
    public partial class NewPhotosToSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "Beasts",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 1,
                column: "Photo",
                value: "/../../img/photo-1630173209442-83f4e940b66b.jpeg");

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 2,
                column: "Photo",
                value: "/../../img/nighthawk-shoots-BOuggN1tMEk-unsplash.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "Beasts",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 1,
                column: "Photo",
                value: "https://unsplash.com/photos/_bweKYLQbGU");

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 2,
                column: "Photo",
                value: "https://unsplash.com/photos/BOuggN1tMEk");
        }
    }
}
