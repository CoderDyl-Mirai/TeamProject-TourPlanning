using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedCork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Description", "Name", "Price", "TourId" },
                values: new object[] { 11, "", "Audio Guide", 3.00m, 9 });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "Description", "Duration", "Image", "Location", "MaxCapacity", "MinCapacity", "Name", "Price" },
                values: new object[,]
                {
                    { 10, "Join us for a unique experience observing fin, humpback, and minke whales, along with common dolphins, basking sharks, harbour porpoises, sunfish, and other marine wildlife. Enjoy breathtaking scenery as you explore the stunning waters and coastline of Cork, discovering incredible marine life in its natural habitat on an unforgettable adventure.", 60, "\\Images\\Tours\\Whale.jpg", "Cork", 30, 10, "Whale Watching", 20.00m },
                    { 11, "Built nearly six hundred years ago by one of Ireland’s greatest chieftains, Cormac MacCarthy, this historic site has attracted attention ever since. Legend says there is a stone that, if kissed, grants eloquence: “Whoever kisses it never misses to grow eloquent.” A fascinating stop on your visiting tour in Ireland.", 80, "\\Images\\Tours\\Blarney.jpg", "Cork", 23, 8, "Blarney Castle", 18.00m },
                    { 12, "Join our food tour led by a local guide as you explore vibrant market stalls filled with fresh seasonal vegetables, poultry, beef, and game like wild Irish rabbit. Enjoy spices, chocolate, coffee bars, and sizzling sausages on the griddle while discovering authentic flavours and stories behind Cork's food culture.", 70, "\\Images\\Tours\\Market.jpg", "Cork", 10, 6, "The English Market", 22.00m }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Description", "Name", "Price", "TourId" },
                values: new object[,]
                {
                    { 12, "", "Wildlife Guide", 6.00m, 10 },
                    { 13, "", "Waterproof Jacket", 20.00m, 10 },
                    { 14, "", "Booklet", 5.00m, 11 },
                    { 15, "", "Recipe Book", 7.50m, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
