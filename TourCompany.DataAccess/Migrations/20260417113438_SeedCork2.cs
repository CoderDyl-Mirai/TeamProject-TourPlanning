using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedCork2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Join us for a unique experience observing fin, humpback, and minke whales, along with common dolphins, basking sharks, harbour porpoises, sunfish, and other marine wildlife. Enjoy breathtaking scenery as you explore the stunning waters and coastline of Cork, discovering incredible marine life on an unforgettable adventure.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Join us for a unique experience observing fin, humpback, and minke whales, along with common dolphins, basking sharks, harbour porpoises, sunfish, and other marine wildlife. Enjoy breathtaking scenery as you explore the stunning waters and coastline of Cork, discovering incredible marine life in its natural habitat on an unforgettable adventure.");
        }
    }
}
