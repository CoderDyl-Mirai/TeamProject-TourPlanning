using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemoveTourDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Tours");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Tours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "619ee4c3-05fa-40d3-81dd-609d9fbdd548", "63463f54-7154-41c4-ae33-2ec9c2890fda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d81b9fb-3554-4807-b7b7-71fdb1799ebd", "64d38cce-7232-42c0-8857-95376169def0" });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2026, 6, 15, 10, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2026, 7, 2, 13, 30, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2026, 6, 15, 15, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2026, 7, 21, 14, 45, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2026, 7, 12, 11, 30, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2026, 7, 25, 9, 45, 0, 0, DateTimeKind.Utc));
        }
    }
}
