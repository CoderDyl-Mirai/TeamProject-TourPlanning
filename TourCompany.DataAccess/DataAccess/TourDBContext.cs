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
                new Tour { Id = 1, Name = "Glenveagh", Description = "Discover Glenveagh National Park on a scenic walking tour through rugged mountains, peaceful lakeshores, and native woodland. Follow tranquil paths to Glenveagh Castle, explore beautiful gardens, and experience breathtaking views, rich wildlife, and the park’s unique natural and cultural heritage.", Price = 15.00m, Image = @"\Images\Tours\Glenveagh.jpg", MaxCapacity = 20, MinCapacity = 5, Duration = 120, Location = "Donegal" },
                new Tour { Id = 2, Name = "Fanad Lighthouse", Description = "Experience Fanad Lighthouse with a local guide, exploring the peninsula’s history. Learn about lighthouse keepers’ lives, stories of love, loss, and resilience. Discover how light has evolved over centuries with modern technology. Experience an authentic insight into life at this iconic Irish landmark.", Price = 12.50m, Image = @"\Images\Tours\Fanad.jpg", MaxCapacity = 12, MinCapacity = 4, Duration = 50, Location = "Donegal" },
                new Tour { Id = 3, Name = "Slieve League", Description = "Join our Sliabh Liag walking tour from the Visitor Centre, exploring stunning cliffs, local culture, and history. Enjoy daily departures, guided insights into language and heritage, and breathtaking scenery, supported by DCC, Fáilte Ireland, and EU funding for an immersive and memorable experience.", Price = 17.00m, Image = @"\Images\Tours\Slieve.jpg", MaxCapacity = 25, MinCapacity = 6, Duration = 90, Location = "Donegal" },
                new Tour { Id = 4, Name = "Guinness", Description = "Join an intimate Guinness tasting at St. James’s Gate, where a beer specialist guides you through flavors, aromas, and origins. Share stories with the group while exploring iconic Guinness varieties and learn the secrets behind Ireland’s famous brew in a memorable, immersive experience.", Price = 30.00m, Image = @"\Images\Tours\Guinness.jpg", MaxCapacity = 15, MinCapacity = 4, Duration = 60, Location = "Dublin" },
                new Tour { Id = 5, Name = "Kilmainham Gaol", Description = "Explore Kilmainham Gaol and uncover Ireland’s history through the stories of prisoners—from ordinary criminals to freedom fighters. Learn about the 1798 Rebellion, 1916 Easter Rising,  and Civil War, each chapter revealing the struggles and resilience that shaped Ireland’s journey to independence.", Price = 25.00m, Image = @"\Images\Tours\Kilmainham.jpg", MaxCapacity = 28, MinCapacity = 7, Duration = 60, Location = "Dublin" },
                new Tour { Id = 6, Name = "Titanic Belfast", Description = "Experience the Titanic story through ten interactive galleries in a self-guided tour. Discover the sights, sounds, and stories of the ship, its passengers, and the city that built her, for the world’s most authentic and immersive retelling of this iconic maritime journey.", Price = 27.50m, Image = @"\Images\Tours\Titanic.jpg", MaxCapacity = 20, MinCapacity = 5, Duration = 100, Location = "Antrim" }
            );

            modelBuilder.Entity<Extra>()
                .HasData(
                new Extra { Id = 1, Name = "Picnic", Description = "", Price = 20.00m, TourId = 3 },
                new Extra { Id = 2, Name = "Picnic", Description = "", Price = 20.00m, TourId = 1 },
                new Extra { Id = 3, Name = "Audio Guide", Description = "", Price = 4.00m, TourId = 5 },
                new Extra { Id = 4, Name = "Pour a Pint", Description = "", Price = 5.00m, TourId = 4 },
                new Extra { Id = 5, Name = "Bike Rental", Description = "", Price = 8.00m, TourId = 1 }
            );

        }


    }
}
