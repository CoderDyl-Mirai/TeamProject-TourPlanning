using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _120326 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8eded0c4-dd1f-4bd1-8dd9-2e3347f6c1e4", "36779740-e7bd-4a2e-9904-7565d47ef6d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02cbbf20-9e9f-430b-8a95-3f329ec132f8", "74e6b424-5538-4062-ad15-5d08b64508b7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "664589b5-9324-4ba3-893c-80246b2372fa", "499e0f17-954b-46db-97bf-b98adb9bec83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1870b8f-b255-4be2-a9cd-bd070386de7f", "5d7e753f-1e51-45e4-b6ce-33f58db595c4" });
        }
    }
}
