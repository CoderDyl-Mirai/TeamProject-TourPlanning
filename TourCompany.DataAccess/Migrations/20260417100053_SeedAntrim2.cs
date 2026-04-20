using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedAntrim2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Description", "Name", "Price", "TourId" },
                values: new object[,]
                {
                    { 6, "", "Picnic", 20.00m, 8 },
                    { 7, "", "Picnic", 20.00m, 7 },
                    { 8, "", "Map", 2.50m, 8 }
                });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Embark on a 5-star rated Giant’s Causeway tour from Belfast — travel to this UNESCO World Heritage Site in a luxury, air-conditioned coach, visit stunning coastal locations, explore ancient castles, and uncover myths and legends Belfast has to offer.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Embark on a 5-star rated Giant’s Causeway tour from Belfast — travel in a luxury, air-conditioned coach, visit stunning coastal locations, explore ancient castles, and uncover myths and legends. Entry to the UNESCO World Heritage Site at the Giant’s Causeway stones is included in your ticket price.");
        }
    }
}
