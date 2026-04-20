using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedAntrim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "Description", "Duration", "Image", "Location", "MaxCapacity", "MinCapacity", "Name", "Price" },
                values: new object[,]
                {
                    { 7, "Embark on a 5-star rated Giant’s Causeway tour from Belfast — travel in a luxury, air-conditioned coach, visit stunning coastal locations, explore ancient castles, and uncover myths and legends. Entry to the UNESCO World Heritage Site at the Giant’s Causeway stones is included in your ticket price.", 60, "\\Images\\Tours\\Causeway.jpg", "Antrim", 20, 5, "Giants Causeway", 10.00m },
                    { 8, "At Belfast Zoo you can see more than 1,000 animals over the course of your visit. The zoo is home to more than 130 different species, most of which are currently endangered in the wild. Learn more about the animals by attending a private walking tour.", 120, "\\Images\\Tours\\BelfastZoo.jpg", "Antrim", 5, 1, "Belfast Zoo", 25.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
