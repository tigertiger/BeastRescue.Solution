using Microsoft.EntityFrameworkCore.Migrations;

namespace BeastRescue.Migrations
{
    public partial class MoreSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Beasts",
                columns: new[] { "BeastId", "Age", "Description", "Gender", "Name", "Photo", "Species", "Temperment" },
                values: new object[,]
                {
                    { 3, 9, "Silvery, quite fatsome", "Female", "Biddy", "/../../img/noelle-KmrmYDyiExg-unsplash.jpeg", "Hog", "Crotchety; recovering from trauma; big love dove, really" },
                    { 4, 4, "Looks like a haystack", "Female", "Haystack", "/../../img/callum-hill-Zx6ZD3n6x4A-unsplash.jpeg", "Hog", "Mercurial, playful, lazy" },
                    { 5, 15, "Furry, brown, large", "Male", "Lonely", "/../../img/mark-basarab-y421kXlUOQk-unsplash.jpeg", "Brown Bear", "Social & snuggly" },
                    { 6, 8, "Stinky, loud, mustachioed", "Male", "Hobnail", "/../../img/taylor-wright-xFzaWaNxXSc-unsplash.jpeg", "Sea Lion", "Unruly!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 6);
        }
    }
}
