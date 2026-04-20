using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedExtraFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Includes drinks and sandwiches for up to 4 people");

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Includes drinks and sandwiches for up to 4 people");

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Self guided cycling tour to enjoy the sights and views");

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Includes drinks and sandwiches for up to 4 people");

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Includes drinks and sandwiches for up to 4 people");

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Includes drinks and sandwiches for up to 4 people");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Includes drinks, sandwiches and fruit for up to 4 people");

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Includes drinks, sandwiches and fruit for up to 4 people");

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Self guided cycling tour to take in the views");

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Includes drinks, sandwiches and fruit for up to 4 people");

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Includes drinks, sandwiches and fruit for up to 4 people");

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Includes drinks, sandwiches and fruit for up to 4 people");
        }
    }
}
