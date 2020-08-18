using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Travels");

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Topspot = table.Column<string>(nullable: true),
                    Review = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country", "Rating", "Review", "Topspot" },
                values: new object[] { 1, "Toyko", "Japan", 5, "Cherry Blossoms Galore!", "Toyko Tower" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country", "Rating", "Review", "Topspot" },
                values: new object[] { 2, "Portland", "USA", 4, "Beer & Coffee Lovers Paradise", "Voodoo Doughnuts" });

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "City", "Country", "Rating", "Review", "Topspot" },
                values: new object[] { 3, "Medellin", "Colombia", 4, "Bachata music", "Botero Plaza" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.CreateTable(
                name: "Travels",
                columns: table => new
                {
                    TravelId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Review = table.Column<string>(nullable: true),
                    Topspot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travels", x => x.TravelId);
                });

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
    }
}
