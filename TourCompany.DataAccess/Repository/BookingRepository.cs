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
    public class BookingRepository : Repository<Booking>, IBookingRepository
    {
        private readonly TourDBContext _dBContext;
        public BookingRepository(TourDBContext dbContext) : base(dbContext)
        {
            _dBContext = dbContext;
        }
        
        public List<Booking> CustomerBooking(string id)
        {
             var bookingList = _dBContext.Bookings.Where(b => b.CustomerId == id).ToList();
             return bookingList;
        }

        public object GetBookingsOfTour(int id)
        {
            var bookingOfTour = _dBContext.Bookings
                .Where(b => b.TourId == id)
                .Select(b => new
            {
                b.Date,
                b.TicketAmount,
                b.Time
            })
            .ToList();
            return bookingOfTour;
        }

        public List<Booking> BookingDetails(string id)
        {
            var bookingDetails = _dBContext.Bookings.Where(b => b.CustomerId == id)
                .Include(b => b.Tour)
                .Include(b => b.BookingExtras)
                .ThenInclude(e => e.Extra)
                .OrderByDescending(b => b.Status == "Confirmed")
                .ThenByDescending(b => b.Date)
                .ToList();
            return bookingDetails;
        }

    }
}
