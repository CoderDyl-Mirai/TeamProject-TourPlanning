using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.DataAccess.DataAccess;
using TourCompany.Models.Models;

namespace TourCompany.DataAccess.Repository
{
    public class BookingRepository : Repository<Booking>, IBookingRepository
    {
        private readonly TourDBContext _dBContext;
        public BookingRepository(TourDBContext dbContext) : base(dbContext)
        {
            _dBContext = dbContext;
        }
    }
}
