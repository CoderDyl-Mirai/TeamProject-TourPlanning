using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TourCompany.DataAccess.DataAccess;
using TourCompany.Models.Models;

namespace TourCompany.Pages.Admin.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly TourDBContext _dbContext;
        public IEnumerable<Booking> Bookings;
        public IndexModel(TourDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task OnGetAsync()
        {
            Bookings = await _dbContext.Bookings.ToListAsync();
        }
    }
}
