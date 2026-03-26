using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Models.Models;

namespace TourCompany.DataAccess.Repository
{
    public interface IBookingExtraRepository : IRepository<BookingExtra>
    {
        List<BookingExtra> GetBooking (int id);
    }
}
