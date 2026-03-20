using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07c7f616-ee09-423a-b081-65785eff6cc9", "a84867f8-a464-4a3a-8e02-88bc15970ba8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55a894e1-83a2-4048-bfc3-d95b2cb53a4b", "bafc23fc-ee47-4dc8-9468-60c9ee270eb9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
