using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourCompany.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Summary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
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
                    BookingImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxCapacity = table.Column<int>(type: "int", nullable: false),
                    MinCapacity = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketAmount = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
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
                columns: new[] { "Id", "BookingImage", "Description", "Duration", "Image", "Location", "MaxCapacity", "MinCapacity", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "\\Images\\Tours\\Glenveagh2.jpg", "Discover Glenveagh National Park on a scenic walking tour through rugged mountains, peaceful lakeshores, and native woodland. Follow tranquil paths to Glenveagh Castle, explore beautiful gardens, and experience breathtaking views, rich wildlife, and the park’s unique natural and cultural heritage.", 120, "\\Images\\Tours\\Glenveagh.jpg", "Donegal", 20, 5, "Glenveagh", 15.00m },
                    { 2, "\\Images\\Tours\\Fanad2.jpg", "Experience Fanad Lighthouse with a local guide, exploring the peninsula’s history. Learn about lighthouse keepers’ lives, stories of love, loss, and resilience. Discover how light has evolved over centuries with modern technology. Experience an authentic insight into life at this iconic Irish landmark.", 50, "\\Images\\Tours\\Fanad.jpg", "Donegal", 12, 4, "Fanad Lighthouse", 12.50m },
                    { 3, "\\Images\\Tours\\Slieve2.jpg", "Join our Sliabh Liag walking tour from the Visitor Centre, exploring stunning cliffs, local culture, and history. Enjoy daily departures, guided insights into language and heritage, and breathtaking scenery, supported by DCC, Fáilte Ireland, and EU funding for an immersive and memorable experience.", 90, "\\Images\\Tours\\Slieve.jpg", "Donegal", 25, 6, "Slieve League", 17.00m },
                    { 4, "\\Images\\Tours\\Guinness2.jpg", "Join an intimate Guinness tasting at St. James’s Gate, where a beer specialist guides you through flavors, aromas, and origins. Share stories with the group while exploring iconic Guinness varieties and learn the secrets behind Ireland’s famous brew in a memorable, immersive experience.", 60, "\\Images\\Tours\\Guinness.jpg", "Dublin", 15, 4, "Guinness", 30.00m },
                    { 5, "\\Images\\Tours\\Kilmainham2.jpg", "Explore Kilmainham Gaol and uncover Ireland’s history through the stories of prisoners—from ordinary criminals to freedom fighters. Learn about the 1798 Rebellion, 1916 Easter Rising,  and Civil War, each chapter revealing the struggles and resilience that shaped Ireland’s journey to independence.", 60, "\\Images\\Tours\\Kilmainham.jpg", "Dublin", 28, 7, "Kilmainham Gaol", 25.00m },
                    { 6, "\\Images\\Tours\\Titanic2.jpg", "Experience the Titanic story through ten interactive galleries in a self-guided tour. Discover the sights, sounds, and stories of the ship, its passengers, and the city that built her, for the world’s most authentic and immersive retelling of this iconic maritime journey.", 100, "\\Images\\Tours\\Titanic.jpg", "Antrim", 20, 5, "Titanic Belfast", 27.50m },
                    { 7, "\\Images\\Tours\\Causeway2.jpg", "Embark on a 5-star rated Giant’s Causeway tour from Belfast — travel to this UNESCO World Heritage Site in a luxury, air-conditioned coach, visit stunning coastal locations, explore ancient castles, and uncover myths and legends Belfast has to offer.", 60, "\\Images\\Tours\\Causeway.jpg", "Antrim", 20, 5, "Giants Causeway", 10.00m },
                    { 8, "\\Images\\Tours\\BelfastZoo2.jpg", "At Belfast Zoo you can see more than 1,000 animals over the course of your visit. The zoo is home to more than 130 different species, most of which are currently endangered in the wild. Learn more about the animals by attending a private walking tour.", 120, "\\Images\\Tours\\BelfastZoo.jpg", "Antrim", 5, 1, "Belfast Zoo", 25.00m },
                    { 9, "\\Images\\Tours\\DublinTour2.jpg", "See Dublin through a local’s eyes on our walking tour, exploring its history and culture. Visit iconic landmarks like Dublin Castle and Trinity College, hear fascinating stories, and discover hidden gems while experiencing the city’s past and present in a memorable way with a local guide.", 45, "\\Images\\Tours\\DublinTour.jpg", "Dublin", 10, 5, "Walking Tour", 4.00m },
                    { 10, "\\Images\\Tours\\Whale2.jpg", "Join us for a unique experience observing fin, humpback, and minke whales, along with common dolphins, basking sharks, and other marine wildlife. Enjoy breathtaking scenery as you explore the stunning waters and coastline of Cork, discovering incredible marine life on an unforgettable adventure.", 60, "\\Images\\Tours\\Whale.jpg", "Cork", 30, 10, "Whale Watching", 20.00m },
                    { 11, "\\Images\\Tours\\Blarney2.jpg", "Built nearly six hundred years ago by one of Ireland’s greatest chieftains, Cormac MacCarthy, this historic site has attracted attention ever since. Legend says there is a stone that, if kissed, grants eloquence: “Whoever kisses it never misses to grow eloquent.” A fascinating stop on your visiting tour in Ireland.", 80, "\\Images\\Tours\\Blarney.jpg", "Cork", 23, 8, "Blarney Castle", 18.00m },
                    { 12, "\\Images\\Tours\\Market2.jpg", "Join our food tour led by a local guide as you explore vibrant market stalls filled with fresh seasonal vegetables, poultry, beef, and game like wild Irish rabbit. Enjoy spices, chocolate, coffee bars, and sizzling sausages on the griddle while discovering authentic flavours and stories behind Cork's food culture.", 70, "\\Images\\Tours\\Market.jpg", "Cork", 10, 6, "The English Market", 22.00m },
                    { 13, "\\Images\\Tours\\Galway2.jpg", "Explore Galway city with a local guide, who will make sure you see all the famous landmarks in town, but show you some hidden ones you may not find if you were on a self-guided tour.Start in Eyre Square, learn about the Browne Doorway, check out statues, castles, churches, and much more along the way.", 70, "\\Images\\Tours\\Galway.jpg", "Galway", 15, 5, "Walking Tour", 5.00m },
                    { 14, "\\Images\\Tours\\Kylemore2.jpg", "Nestled in the heart of Connemara, on the Wild Atlantic Way, Kylemore Abbey is a haven of history, beauty and serenity. Home to a Benedictine order of Nuns for the past 100 years, Kylemore Abbey welcomes visitors from all over the world each year to embrace the magic of the magnificent 1,000-acre estate.", 180, "\\Images\\Tours\\Kylemore.jpg", "Galway", 20, 1, "Kylemore Abbey", 14.00m },
                    { 15, "\\Images\\Tours\\Connemara2.jpg", "Experience Connemara National Park on a full-day walking tour with a local guide. Covering 2,000 hectares of mountains, bogs, and woodlands in Galway, you’ll explore the Twelve Bens range, including Benbaun and Bencullagh. Discover the area’s natural beauty, history, and unique landscapes.", 480, "\\Images\\Tours\\Connemara.jpg", "Galway", 30, 10, "Connemara Park", 30.00m }
                });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Description", "Name", "Price", "TourId" },
                values: new object[,]
                {
                    { 1, "Includes drinks and sandwiches for up to 4 people", "Picnic", 20.00m, 3 },
                    { 2, "Includes drinks and sandwiches for up to 4 people", "Picnic", 20.00m, 1 },
                    { 3, "Provides self-guided commentary and stories throughout the tour.", "Audio Guide", 4.00m, 5 },
                    { 4, "Learn to pour and enjoy the perfect pint of Guinness", "Pour a Pint", 5.00m, 4 },
                    { 5, "Self guided cycling tour to enjoy the sights and views", "Bike Rental", 8.00m, 1 },
                    { 6, "Includes drinks and sandwiches for up to 4 people", "Picnic", 20.00m, 8 },
                    { 7, "Includes drinks and sandwiches for up to 4 people", "Picnic", 20.00m, 7 },
                    { 8, "Follow the route and learn about all the animals", "Map", 2.50m, 8 },
                    { 9, "Follow the route and highlights of the city", "Booklet", 1.00m, 9 },
                    { 10, "Provides self-guided commentary and stories throughout the tour.", "Audio Guide", 3.00m, 9 },
                    { 11, "Provides self-guided commentary and stories throughout the tour.", "Audio Guide", 3.00m, 13 },
                    { 12, "Spot and learn about the various wildlife species", "Wildlife Guide", 6.00m, 10 },
                    { 13, "Stay dry during the tour", "Waterproof Jacket", 20.00m, 10 },
                    { 14, "A guide to the history and stories of the castle", "Booklet", 5.00m, 11 },
                    { 15, "Create your own dishes with local Irish recipes", "Recipe Book", 7.50m, 12 },
                    { 16, "Follow the route and highlights of the city", "Booklet", 5.00m, 13 },
                    { 17, "A guide to the history and stories of the Abbey", "Booklet", 5.00m, 14 },
                    { 18, "Includes drinks and sandwiches for up to 4 people", "Picnic", 20.00m, 15 },
                    { 19, "Provides self-guided commentary and stories throughout the tour.", "Audio Guide", 4.00m, 2 },
                    { 20, "Provides self-guided commentary and stories throughout the tour.", "Audio Guide", 4.00m, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookingExtras");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Extras");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tours");
        }
    }
}
