using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedGalway : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "Description", "Duration", "Image", "Location", "MaxCapacity", "MinCapacity", "Name", "Price" },
                values: new object[,]
                {
                    { 13, "Explore Galway city with a local guide, who will make sure you see all the famous landmarks in town, but show you some hidden ones you may not find if you were on a self-guided tour.Start in Eyre Square, learn about the Browne Doorway, check out statues, castles, churches, and much more along the way.", 70, "\\Images\\Tours\\Galway.jpg", "Galway", 15, 5, "Walking Tour", 5.00m },
                    { 14, "Nestled in the heart of Connemara, on the Wild Atlantic Way, Kylemore Abbey is a haven of history, beauty and serenity. Home to a Benedictine order of Nuns for the past 100 years, Kylemore Abbey welcomes visitors from all over the world each year to embrace the magic of the magnificent 1,000-acre estate.", 180, "\\Images\\Tours\\Kylemore.jpg", "Galway", 20, 1, "Kylemore Abbey", 14.00m },
                    { 15, "Experience Connemara National Park on a full-day walking tour with a local guide. Covering 2,000 hectares of mountains, bogs, and woodlands in Galway, you’ll explore the Twelve Bens range, including Benbaun and Bencullagh. Discover the area’s natural beauty, history, and unique landscapes.", 480, "\\Images\\Tours\\Connemara.jpg", "Galway", 30, 10, "Connemara Park", 30.00m }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Description", "Name", "Price", "TourId" },
                values: new object[,]
                {
                    { 16, "", "Booklet", 5.00m, 13 },
                    { 17, "", "Booklet", 5.00m, 14 },
                    { 18, "", "Picnic", 20.00m, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
