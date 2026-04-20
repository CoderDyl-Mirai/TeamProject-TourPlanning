using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TourCompany.Models.Models;


namespace TourCompany.DataAccess.DataAccess
{
    public class TourDBContext : IdentityDbContext
    {
        public TourDBContext(DbContextOptions<TourDBContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Extra> Extras { get; set; }

        public DbSet<BookingExtra> BookingExtras { get; set; }
        public DbSet<Tour> Tours { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tour>()
                .HasData(
                new Tour { Id = 1, Name = "Glenveagh", Description = "Discover Glenveagh National Park on a scenic walking tour through rugged mountains, peaceful lakeshores, and native woodland. Follow tranquil paths to Glenveagh Castle, explore beautiful gardens, and experience breathtaking views, rich wildlife, and the park’s unique natural and cultural heritage.", Price = 15.00m, Image = @"\Images\Tours\Glenveagh.jpg", BookingImage = @"\Images\Tours\Glenveagh2.jpg", MaxCapacity = 20, MinCapacity = 5, Duration = 120, Location = "Donegal" },
                new Tour { Id = 2, Name = "Fanad Lighthouse", Description = "Experience Fanad Lighthouse with a local guide, exploring the peninsula’s history. Learn about lighthouse keepers’ lives, stories of love, loss, and resilience. Discover how light has evolved over centuries with modern technology. Experience an authentic insight into life at this iconic Irish landmark.", Price = 12.50m, Image = @"\Images\Tours\Fanad.jpg", BookingImage = @"\Images\Tours\Fanad2.jpg", MaxCapacity = 12, MinCapacity = 4, Duration = 50, Location = "Donegal" },
                new Tour { Id = 3, Name = "Slieve League", Description = "Join our Sliabh Liag walking tour from the Visitor Centre, exploring stunning cliffs, local culture, and history. Enjoy daily departures, guided insights into language and heritage, and breathtaking scenery, supported by DCC, Fáilte Ireland, and EU funding for an immersive and memorable experience.", Price = 17.00m, Image = @"\Images\Tours\Slieve.jpg", BookingImage = @"\Images\Tours\Slieve2.jpg", MaxCapacity = 25, MinCapacity = 6, Duration = 90, Location = "Donegal" },
                new Tour { Id = 4, Name = "Guinness", Description = "Join an intimate Guinness tasting at St. James’s Gate, where a beer specialist guides you through flavors, aromas, and origins. Share stories with the group while exploring iconic Guinness varieties and learn the secrets behind Ireland’s famous brew in a memorable, immersive experience.", Price = 30.00m, Image = @"\Images\Tours\Guinness.jpg", BookingImage = @"\Images\Tours\Guinness2.jpg", MaxCapacity = 15, MinCapacity = 4, Duration = 60, Location = "Dublin" },
                new Tour { Id = 5, Name = "Kilmainham Gaol", Description = "Explore Kilmainham Gaol and uncover Ireland’s history through the stories of prisoners—from ordinary criminals to freedom fighters. Learn about the 1798 Rebellion, 1916 Easter Rising,  and Civil War, each chapter revealing the struggles and resilience that shaped Ireland’s journey to independence.", Price = 25.00m, Image = @"\Images\Tours\Kilmainham.jpg", BookingImage = @"\Images\Tours\Kilmainham2.jpg", MaxCapacity = 28, MinCapacity = 7, Duration = 60, Location = "Dublin" },
                new Tour { Id = 6, Name = "Titanic Belfast", Description = "Experience the Titanic story through ten interactive galleries in a self-guided tour. Discover the sights, sounds, and stories of the ship, its passengers, and the city that built her, for the world’s most authentic and immersive retelling of this iconic maritime journey.", Price = 27.50m, Image = @"\Images\Tours\Titanic.jpg", BookingImage = @"\Images\Tours\Titanic2.jpg", MaxCapacity = 20, MinCapacity = 5, Duration = 100, Location = "Antrim" },
                new Tour { Id = 7, Name = "Giants Causeway", Description = "Embark on a 5-star rated Giant’s Causeway tour from Belfast — travel to this UNESCO World Heritage Site in a luxury, air-conditioned coach, visit stunning coastal locations, explore ancient castles, and uncover myths and legends Belfast has to offer.", Price = 10.00m, Image = @"\Images\Tours\Causeway.jpg", BookingImage = @"\Images\Tours\Causeway2.jpg", MaxCapacity = 20, MinCapacity = 5, Duration = 60, Location = "Antrim" },
                new Tour { Id = 8, Name = "Belfast Zoo", Description = "At Belfast Zoo you can see more than 1,000 animals over the course of your visit. The zoo is home to more than 130 different species, most of which are currently endangered in the wild. Learn more about the animals by attending a private walking tour.", Price = 25.00m, Image = @"\Images\Tours\BelfastZoo.jpg", BookingImage = @"\Images\Tours\BelfastZoo2.jpg", MaxCapacity = 5, MinCapacity = 1, Duration = 120, Location = "Antrim" },
                new Tour { Id = 9, Name = "Walking Tour", Description = "See Dublin through a local’s eyes on our walking tour, exploring its history and culture. Visit iconic landmarks like Dublin Castle and Trinity College, hear fascinating stories, and discover hidden gems while experiencing the city’s past and present in a memorable way with a local guide.", Price = 4.00m, Image = @"\Images\Tours\DublinTour.jpg", BookingImage = @"\Images\Tours\DublinTour2.jpg", MaxCapacity = 10, MinCapacity = 5, Duration = 45, Location = "Dublin" },
                new Tour { Id = 10, Name = "Whale Watching", Description = "Join us for a unique experience observing fin, humpback, and minke whales, along with common dolphins, basking sharks, and other marine wildlife. Enjoy breathtaking scenery as you explore the stunning waters and coastline of Cork, discovering incredible marine life on an unforgettable adventure.", Price = 20.00m, Image = @"\Images\Tours\Whale.jpg", BookingImage = @"\Images\Tours\Whale2.jpg", MaxCapacity = 30, MinCapacity = 10, Duration = 60, Location = "Cork" },
                new Tour { Id = 11, Name = "Blarney Castle", Description = "Built nearly six hundred years ago by one of Ireland’s greatest chieftains, Cormac MacCarthy, this historic site has attracted attention ever since. Legend says there is a stone that, if kissed, grants eloquence: “Whoever kisses it never misses to grow eloquent.” A fascinating stop on your visiting tour in Ireland.", Price = 18.00m, Image = @"\Images\Tours\Blarney.jpg", BookingImage = @"\Images\Tours\Blarney2.jpg", MaxCapacity = 23, MinCapacity = 8, Duration = 80, Location = "Cork" },
                new Tour { Id = 12, Name = "The English Market", Description = "Join our food tour led by a local guide as you explore vibrant market stalls filled with fresh seasonal vegetables, poultry, beef, and game like wild Irish rabbit. Enjoy spices, chocolate, coffee bars, and sizzling sausages on the griddle while discovering authentic flavours and stories behind Cork's food culture.", Price = 22.00m, Image = @"\Images\Tours\Market.jpg", BookingImage = @"\Images\Tours\Market2.jpg", MaxCapacity = 10, MinCapacity = 6, Duration = 70, Location = "Cork" },
                new Tour { Id = 13, Name = "Walking Tour", Description = "Explore Galway city with a local guide, who will make sure you see all the famous landmarks in town, but show you some hidden ones you may not find if you were on a self-guided tour.Start in Eyre Square, learn about the Browne Doorway, check out statues, castles, churches, and much more along the way.", Price = 5.00m, Image = @"\Images\Tours\Galway.jpg", BookingImage = @"\Images\Tours\Galway2.jpg", MaxCapacity = 15, MinCapacity = 5, Duration = 70, Location = "Galway" },
                new Tour { Id = 14, Name = "Kylemore Abbey", Description = "Nestled in the heart of Connemara, on the Wild Atlantic Way, Kylemore Abbey is a haven of history, beauty and serenity. Home to a Benedictine order of Nuns for the past 100 years, Kylemore Abbey welcomes visitors from all over the world each year to embrace the magic of the magnificent 1,000-acre estate.", Price = 14.00m, Image = @"\Images\Tours\Kylemore.jpg", BookingImage = @"\Images\Tours\Kylemore2.jpg", MaxCapacity = 20, MinCapacity = 1, Duration = 180, Location = "Galway" },
                new Tour { Id = 15, Name = "Connemara Park", Description = "Experience Connemara National Park on a full-day walking tour with a local guide. Covering 2,000 hectares of mountains, bogs, and woodlands in Galway, you’ll explore the Twelve Bens range, including Benbaun and Bencullagh. Discover the area’s natural beauty, history, and unique landscapes.", Price = 30.00m, Image = @"\Images\Tours\Connemara.jpg", BookingImage = @"\Images\Tours\Connemara2.jpg", MaxCapacity = 30, MinCapacity = 10, Duration = 480, Location = "Galway" }
            );

            modelBuilder.Entity<Extra>()
                .HasData(
                new Extra { Id = 1, Name = "Picnic", Description = "Includes drinks and sandwiches for up to 4 people", Price = 20.00m, TourId = 3 },
                new Extra { Id = 2, Name = "Picnic", Description = "Includes drinks and sandwiches for up to 4 people", Price = 20.00m, TourId = 1 },
                new Extra { Id = 3, Name = "Audio Guide", Description = "Provides self-guided commentary and stories throughout the tour.", Price = 4.00m, TourId = 5 },
                new Extra { Id = 4, Name = "Pour a Pint", Description = "Learn to pour and enjoy the perfect pint of Guinness", Price = 5.00m, TourId = 4 },
                new Extra { Id = 5, Name = "Bike Rental", Description = "Self guided cycling tour to enjoy the sights and views", Price = 8.00m, TourId = 1 },
                new Extra { Id = 6, Name = "Picnic", Description = "Includes drinks and sandwiches for up to 4 people", Price = 20.00m, TourId = 8 },
                new Extra { Id = 7, Name = "Picnic", Description = "Includes drinks and sandwiches for up to 4 people", Price = 20.00m, TourId = 7 },
                new Extra { Id = 8, Name = "Map", Description = "Follow the route and learn about all the animals", Price = 2.50m, TourId = 8 },
                new Extra { Id = 9, Name = "Booklet", Description = "Follow the route and highlights of the city", Price = 1.00m, TourId = 9 },
                new Extra { Id = 10, Name = "Audio Guide", Description = "Provides self-guided commentary and stories throughout the tour.", Price = 3.00m, TourId = 9 },
                new Extra { Id = 11, Name = "Audio Guide", Description = "Provides self-guided commentary and stories throughout the tour.", Price = 3.00m, TourId = 13 },
                new Extra { Id = 12, Name = "Wildlife Guide", Description = "Spot and learn about the various wildlife species", Price = 6.00m, TourId = 10 },
                new Extra { Id = 13, Name = "Waterproof Jacket", Description = "Stay dry during the tour", Price = 20.00m, TourId = 10 },
                new Extra { Id = 14, Name = "Booklet", Description = "A guide to the history and stories of the castle", Price = 5.00m, TourId = 11 },
                new Extra { Id = 15, Name = "Recipe Book", Description = "Create your own dishes with local Irish recipes", Price = 7.50m, TourId = 12 },
                new Extra { Id = 16, Name = "Booklet", Description = "Follow the route and highlights of the city", Price = 5.00m, TourId = 13 },
                new Extra { Id = 17, Name = "Booklet", Description = "A guide to the history and stories of the Abbey", Price = 5.00m, TourId = 14 },
                new Extra { Id = 18, Name = "Picnic", Description = "Includes drinks and sandwiches for up to 4 people", Price = 20.00m, TourId = 15 },
                new Extra { Id = 19, Name = "Audio Guide", Description = "Provides self-guided commentary and stories throughout the tour.", Price = 4.00m, TourId = 2 },
                new Extra { Id = 20, Name = "Audio Guide", Description = "Provides self-guided commentary and stories throughout the tour.", Price = 4.00m, TourId = 6 }
            );

        }


    }
}
