using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCustomerSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "guest2");

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price", "TourId" },
                values: new object[] { "Picnic", 20.00m, 1 });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price", "TourId" },
                values: new object[] { "Audio Guide", 4.00m, 5 });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price", "TourId" },
                values: new object[] { "Pour a Pint", 5.00m, 4 });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Description", "Name", "Price", "TourId" },
                values: new object[] { 5, "", "Bike Rental", 8.00m, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CSV", "ConcurrencyStamp", "CreditCardNum", "Discriminator", "Email", "EmailConfirmed", "ExpiryDate", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "guest1", 0, 481, "59d64f96-b7e3-400d-96fa-757c47ca53e3", "7391630561936204", "Customer", "Joe_Bloggs@email.com", false, new DateOnly(2028, 2, 17), "Joe", "Bloggs", false, null, null, null, null, "0986493740", false, "09990af2-6928-4d80-8cce-7154563d766b", false, null },
                    { "guest2", 0, 123, "6d6f4bbd-8729-4b54-a9cd-4e894c96dc49", "3905279573137936", "Customer", "JaneSmith@email.com", false, new DateOnly(2032, 4, 3), "Jane", "Smith", false, null, null, null, null, "0867491503", false, "0691525d-fae4-4f9d-9fd8-09ab72d41a79", false, null }
                });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price", "TourId" },
                values: new object[] { "Audio Guide", 4.00m, 5 });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price", "TourId" },
                values: new object[] { "Pour a Pint", 5.00m, 4 });

            migrationBuilder.UpdateData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price", "TourId" },
                values: new object[] { "Bike Rental", 8.00m, 1 });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CustomerId", "Date", "Status", "TicketAmount", "TotalPrice", "TourId" },
                values: new object[,]
                {
                    { 1, "guest1", new DateTime(2026, 7, 21, 14, 45, 0, 0, DateTimeKind.Utc), "", 2, 60.00m, 4 },
                    { 2, "guest2", new DateTime(2026, 6, 15, 15, 0, 0, 0, DateTimeKind.Utc), "", 4, 68.00m, 3 }
                });
        }
    }
}
