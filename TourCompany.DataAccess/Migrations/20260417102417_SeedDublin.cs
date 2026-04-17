using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDublin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "Description", "Duration", "Image", "Location", "MaxCapacity", "MinCapacity", "Name", "Price" },
                values: new object[] { 9, "See Dublin through a local’s eyes on our free walking tour, exploring its history and culture. Visit iconic landmarks like Dublin Castle and Trinity College, hear fascinating stories, and discover hidden gems while experiencing the city’s past and present in a memorable way with a local guide.", 45, "\\Images\\Tours\\DublinTour.jpg", "Dublin", 10, 5, "Free Walking Tour", 0.00m });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Description", "Name", "Price", "TourId" },
                values: new object[,]
                {
                    { 9, "", "Booklet", 1.00m, 9 },
                    { 10, "", "Audio Guide", 3.00m, 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
