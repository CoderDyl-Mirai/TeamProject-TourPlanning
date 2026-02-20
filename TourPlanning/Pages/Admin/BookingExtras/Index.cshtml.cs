using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TourCompany.DataAccess.DataAccess;
using TourCompany.Models.Models;

namespace TourCompany.Pages.Admin.BookingExtras
{
    public class IndexModel : PageModel
    {
        private readonly TourDBContext _dbContext;
        public IEnumerable<BookingExtra> BookingExtras;
        public IndexModel(TourDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task OnGetAsync()
        {
            BookingExtras = await _dbContext.BookingExtras.ToListAsync();
        }
    }
}
