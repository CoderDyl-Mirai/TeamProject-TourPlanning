using Microsoft.EntityFrameworkCore;
using TourCompany.Models.Models;


namespace TourCompany.DataAccess.DataAccess
{
    public class TourDBContext : DbContext
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
            modelBuilder.Seed();
        }
    }
}
