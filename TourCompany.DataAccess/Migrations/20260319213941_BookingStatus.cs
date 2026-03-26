using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class BookingStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b7af2d3-cc23-407a-8dd8-6dd400b2289f", "1ac15ee3-6a14-4acd-b7a4-52a7b4fc4939" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4eaee3f7-c60a-489c-a51c-ca1803d6c801", "4e5e7d7e-4174-4e67-b129-bdfc940acdf2" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: "");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Bookings");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f25a2d27-65e4-4a6b-81a8-4bca95dc3f90", "072e6ac0-b63a-4494-89e6-b9eab6d6a757" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "17ef1dcc-893d-41b8-b36f-6319525a51e6", "f7fcbe22-403a-4d48-8311-80feb58e3503" });
        }
    }
}
