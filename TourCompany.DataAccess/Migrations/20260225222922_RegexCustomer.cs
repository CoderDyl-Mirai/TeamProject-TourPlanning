using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RegexCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CSV", "CreditCardNum", "Email", "ExpiryDate", "Firstname", "Lastname", "Phone" },
                values: new object[,]
                {
                    { 1, 481, "7391630561936204", "Joe_Bloggs@email.com", new DateOnly(2028, 2, 17), "Joe", "Bloggs", "0986493740" },
                    { 2, 123, "3905279573137936", "JaneSmith@email.com", new DateOnly(2032, 4, 3), "Jane", "Smith", "0867491503" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "Date", "Description", "Duration", "Image", "Location", "MaxCapacity", "MinCapacity", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 15, 10, 0, 0, 0, DateTimeKind.Utc), "Discover Glenveagh National Park on a scenic walking tour through rugged mountains, peaceful lakeshores, and native woodland. Follow tranquil paths to Glenveagh Castle, explore beautiful gardens, and experience breathtaking views, rich wildlife, and the park’s unique natural and cultural heritage.", 120, "\\Images\\Tours\\Glenveagh.jpg", "Donegal", 20, 5, "Glenveagh Walking Tour", 15.00m },
                    { 2, new DateTime(2026, 7, 2, 13, 30, 0, 0, DateTimeKind.Utc), "Experience Fanad Lighthouse with a local guide, exploring the peninsula’s history. Learn about lighthouse keepers’ lives, stories of love, loss, and resilience, and discover how the light has evolved over centuries with modern technology. An authentic, memorable insight into life at this iconic Irish landmark.", 50, "\\Images\\Tours\\Fanad.jpg", "Donegal", 12, 4, "Fanad Lighthouse", 12.50m },
                    { 3, new DateTime(2026, 6, 15, 15, 0, 0, 0, DateTimeKind.Utc), "Join our Sliabh Liag walking tour from the Visitor Centre, exploring stunning cliffs, local culture, and history. Enjoy daily departures, guided insights into language and heritage, and breathtaking scenery, supported by DCC, Fáilte Ireland, and EU funding for an immersive and memorable experience.", 90, "\\Images\\Tours\\Slieve.jpg", "Donegal", 25, 6, "Slieve League", 17.00m },
                    { 4, new DateTime(2026, 7, 21, 14, 45, 0, 0, DateTimeKind.Utc), "Join an intimate Guinness tasting at St. James’s Gate, where a beer specialist guides you through flavors, aromas, and origins. Share stories with the group while exploring iconic Guinness varieties and learn the secrets behind Ireland’s famous brew in a memorable, immersive experience.", 60, "\\Images\\Tours\\Guinness.jpg", "Dublin", 15, 4, "Guinness Storehouse", 30.00m },
                    { 5, new DateTime(2026, 7, 12, 11, 30, 0, 0, DateTimeKind.Utc), "Explore Kilmainham Gaol and uncover Ireland’s history through the stories of prisoners—from ordinary criminals to freedom fighters. Learn about the 1798 Rebellion, 1916 Easter Rising, Anglo-Irish War, and Civil War, each chapter revealing the struggles and resilience that shaped Ireland’s journey to independence.", 60, "\\Images\\Tours\\Kilmainham.jpg", "Dublin", 28, 7, "Kilmainham Gaol", 25.00m },
                    { 6, new DateTime(2026, 7, 25, 9, 45, 0, 0, DateTimeKind.Utc), "Experience the Titanic story through ten interactive galleries in a self-guided tour. Discover the sights, sounds, and stories of the ship, its passengers, and the city that built her, for the world’s most authentic and immersive retelling of this iconic maritime journey.", 100, "\\Images\\Tours\\Titanic.jpg", "Belfast", 20, 5, "Titanic Belfast", 27.50m }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CustomerId", "Date", "TicketAmount", "TotalPrice", "TourId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 7, 21, 14, 45, 0, 0, DateTimeKind.Utc), 2, 60.00m, 4 },
                    { 2, 2, new DateTime(2026, 6, 15, 15, 0, 0, 0, DateTimeKind.Utc), 4, 68.00m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Description", "Name", "Price", "TourId" },
                values: new object[,]
                {
                    { 1, "", "Picnic", 20.00m, 3 },
                    { 2, "", "Audio Guide", 4.00m, 5 },
                    { 3, "", "Pour a Pint", 5.00m, 4 },
                    { 4, "", "Bike Rental", 8.00m, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
