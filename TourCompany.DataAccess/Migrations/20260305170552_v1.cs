using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditCardNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CSV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxCapacity = table.Column<int>(type: "int", nullable: false),
                    MinCapacity = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    TicketAmount = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Extras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Extras_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingExtras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    ExtraId = table.Column<int>(type: "int", nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingExtras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingExtras_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingExtras_Extras_ExtraId",
                        column: x => x.ExtraId,
                        principalTable: "Extras",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "Date", "Description", "Duration", "Image", "Location", "MaxCapacity", "MinCapacity", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 15, 10, 0, 0, 0, DateTimeKind.Utc), "Discover Glenveagh National Park on a scenic walking tour through rugged mountains, peaceful lakeshores, and native woodland. Follow tranquil paths to Glenveagh Castle, explore beautiful gardens, and experience breathtaking views, rich wildlife, and the park’s unique natural and cultural heritage.", 120, "\\Images\\Tours\\Glenveagh.jpg", "Donegal", 20, 5, "Glenveagh", 15.00m },
                    { 2, new DateTime(2026, 7, 2, 13, 30, 0, 0, DateTimeKind.Utc), "Experience Fanad Lighthouse with a local guide, exploring the peninsula’s history. Learn about lighthouse keepers’ lives, stories of love, loss, and resilience. Discover how light has evolved over centuries with modern technology. Experience an authentic insight into life at this iconic Irish landmark.", 50, "\\Images\\Tours\\Fanad.jpg", "Donegal", 12, 4, "Fanad Lighthouse", 12.50m },
                    { 3, new DateTime(2026, 6, 15, 15, 0, 0, 0, DateTimeKind.Utc), "Join our Sliabh Liag walking tour from the Visitor Centre, exploring stunning cliffs, local culture, and history. Enjoy daily departures, guided insights into language and heritage, and breathtaking scenery, supported by DCC, Fáilte Ireland, and EU funding for an immersive and memorable experience.", 90, "\\Images\\Tours\\Slieve.jpg", "Donegal", 25, 6, "Slieve League", 17.00m },
                    { 4, new DateTime(2026, 7, 21, 14, 45, 0, 0, DateTimeKind.Utc), "Join an intimate Guinness tasting at St. James’s Gate, where a beer specialist guides you through flavors, aromas, and origins. Share stories with the group while exploring iconic Guinness varieties and learn the secrets behind Ireland’s famous brew in a memorable, immersive experience.", 60, "\\Images\\Tours\\Guinness.jpg", "Dublin", 15, 4, "Guinness", 30.00m },
                    { 5, new DateTime(2026, 7, 12, 11, 30, 0, 0, DateTimeKind.Utc), "Explore Kilmainham Gaol and uncover Ireland’s history through the stories of prisoners—from ordinary criminals to freedom fighters. Learn about the 1798 Rebellion, 1916 Easter Rising,  and Civil War, each chapter revealing the struggles and resilience that shaped Ireland’s journey to independence.", 60, "\\Images\\Tours\\Kilmainham.jpg", "Dublin", 28, 7, "Kilmainham Gaol", 25.00m },
                    { 6, new DateTime(2026, 7, 25, 9, 45, 0, 0, DateTimeKind.Utc), "Experience the Titanic story through ten interactive galleries in a self-guided tour. Discover the sights, sounds, and stories of the ship, its passengers, and the city that built her, for the world’s most authentic and immersive retelling of this iconic maritime journey.", 100, "\\Images\\Tours\\Titanic.jpg", "Belfast", 20, 5, "Titanic Belfast", 27.50m }
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

            migrationBuilder.CreateIndex(
                name: "IX_BookingExtras_BookingId",
                table: "BookingExtras",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingExtras_ExtraId",
                table: "BookingExtras",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_TourId",
                table: "Bookings",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Extras_TourId",
                table: "Extras",
                column: "TourId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingExtras");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
