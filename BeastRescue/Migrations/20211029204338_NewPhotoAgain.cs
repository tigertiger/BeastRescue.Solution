using Microsoft.EntityFrameworkCore.Migrations;

namespace BeastRescue.Migrations
{
    public partial class NewPhotoAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 1,
                column: "Photo",
                value: "/../../img/pauline-bernfeld-S99OqS453go-unsplash.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 1,
                column: "Photo",
                value: "/../../img/photo-1630173209442-83f4e940b66b.jpeg");
        }
    }
}
