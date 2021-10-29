using Microsoft.EntityFrameworkCore.Migrations;

namespace BeastRescue.Migrations
{
    public partial class ChangeSyntax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 1,
                columns: new[] { "Description", "Temperment" },
                values: new object[] { "is 300+ pounds with black and pink blotch patterning & a scarred snout", "aloof, but loving" });

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 2,
                columns: new[] { "Description", "Temperment" },
                values: new object[] { "is young & fit with goldeny, cream-colored fur", "very sweet. She's a total goof" });

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 3,
                columns: new[] { "Description", "Temperment" },
                values: new object[] { "is silvery & quite fatsome", "crotchety. She's recovering from some trauma, but she's a big love-dove, really" });

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 4,
                columns: new[] { "Description", "Temperment" },
                values: new object[] { "looks like a haystack", "mercurial, playful, & very lazy" });

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 5,
                columns: new[] { "Description", "Temperment" },
                values: new object[] { "is furry, brown, & quite large", "social & snuggly" });

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 6,
                columns: new[] { "Description", "Temperment" },
                values: new object[] { "stinky, loud, & mustachioed", "unruly!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 1,
                columns: new[] { "Description", "Temperment" },
                values: new object[] { "300+ pounds, black and pink blotch patterning, scarred snout", "Aloof, but loving" });

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 2,
                columns: new[] { "Description", "Temperment" },
                values: new object[] { "Goldeny, cream-colored fur. Slender.", "Very sweet; a goof" });

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 3,
                columns: new[] { "Description", "Temperment" },
                values: new object[] { "Silvery, quite fatsome", "Crotchety; recovering from trauma; big love dove, really" });

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 4,
                columns: new[] { "Description", "Temperment" },
                values: new object[] { "Looks like a haystack", "Mercurial, playful, lazy" });

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 5,
                columns: new[] { "Description", "Temperment" },
                values: new object[] { "Furry, brown, large", "Social & snuggly" });

            migrationBuilder.UpdateData(
                table: "Beasts",
                keyColumn: "BeastId",
                keyValue: 6,
                columns: new[] { "Description", "Temperment" },
                values: new object[] { "Stinky, loud, mustachioed", "Unruly!" });
        }
    }
}
