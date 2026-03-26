using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourCompany.DataAccess.DataAccess;
using TourCompany.Models.Models;

namespace TourCompany.DataAccess.Repository
{
    public class BookingExtraRepository : Repository<BookingExtra>, IBookingExtraRepository
    {
        private readonly TourDBContext _dBContext;
        public BookingExtraRepository(TourDBContext dbContext) : base(dbContext)
        {
            _dBContext = dbContext;
        }

        public List<BookingExtra> GetBooking (int id)
        {
            var bookings = _dBContext.BookingExtras.Where(be => be.BookingId == id).ToList();
            return bookings;
        }
    }
}
