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




    }
}
