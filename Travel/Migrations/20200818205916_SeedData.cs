using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TopSpot",
                table: "Travels",
                newName: "Topspot");

            migrationBuilder.InsertData(
                table: "Travels",
                columns: new[] { "TravelId", "City", "Country", "Rating", "Review", "Topspot" },
                values: new object[] { 1, "Toyko", "Japan", 5, "Cherry Blossoms Galore!", "Toyko Tower" });

            migrationBuilder.InsertData(
                table: "Travels",
                columns: new[] { "TravelId", "City", "Country", "Rating", "Review", "Topspot" },
                values: new object[] { 2, "Portland", "USA", 4, "Beer & Coffee Lovers Paradise", "Voodoo Doughnuts" });

            migrationBuilder.InsertData(
                table: "Travels",
                columns: new[] { "TravelId", "City", "Country", "Rating", "Review", "Topspot" },
                values: new object[] { 3, "Medellin", "Colombia", 4, "Bachata music", "Botero Plaza" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Travels",
                keyColumn: "TravelId",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Topspot",
                table: "Travels",
                newName: "TopSpot");
        }
    }
}
