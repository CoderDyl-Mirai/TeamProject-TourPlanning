using Microsoft.EntityFrameworkCore;
using TourCompany.Models.Models;


namespace TourCompany.DataAccess.DataAccess
{
    public class TourDBContext : DbContext
    {
        public TourDBContext(DbContextOptions<TourDBContext> options) : base(options)
        {

        }

        public DbSet<Plan> Plans { get; set; }
    }
}
