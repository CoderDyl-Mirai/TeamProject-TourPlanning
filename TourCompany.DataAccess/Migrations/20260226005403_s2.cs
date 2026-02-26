using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class s2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Glenveagh");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Glenveagh Walking Tour");
        }
    }
}
