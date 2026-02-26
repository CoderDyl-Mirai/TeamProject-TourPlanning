using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class s3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Experience Fanad Lighthouse with a local guide, exploring the peninsula’s history. Learn about lighthouse keepers’ lives, stories of love, loss, and resilience. Discover how light has evolved over centuries with modern technology. Experience an authentic insight into life at this iconic Irish landmark.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Experience Fanad Lighthouse with a local guide, exploring the peninsula’s history. Learn about lighthouse keepers’ lives, stories of love, loss, and resilience, and discover how the light has evolved over centuries with modern technology. An authentic, memorable insight into life at this iconic Irish landmark.");
        }
    }
}
