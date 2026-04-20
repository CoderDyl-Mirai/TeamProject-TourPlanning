using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDublin2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "See Dublin through a local’s eyes on our walking tour, exploring its history and culture. Visit iconic landmarks like Dublin Castle and Trinity College, hear fascinating stories, and discover hidden gems while experiencing the city’s past and present in a memorable way with a local guide.", "Walking Tour", 4.00m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "See Dublin through a local’s eyes on our free walking tour, exploring its history and culture. Visit iconic landmarks like Dublin Castle and Trinity College, hear fascinating stories, and discover hidden gems while experiencing the city’s past and present in a memorable way with a local guide.", "Free Walking Tour", 0.00m });
        }
    }
}
