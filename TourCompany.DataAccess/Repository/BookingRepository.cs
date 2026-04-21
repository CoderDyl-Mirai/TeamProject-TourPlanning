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
                b.Time,
                b.Status
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

        public Booking SummaryDetails(int id)
        {
            var summary =_dBContext.Bookings.Include(b => b.Customer)
                                      .Include(b => b.Tour)
                                      .Include(b => b.BookingExtras)
                                      .ThenInclude(be => be.Extra)
                                      .FirstOrDefault(b => b.Id == id);
            return summary;
        }

    }
}
