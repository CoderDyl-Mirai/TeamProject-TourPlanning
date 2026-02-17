using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TourCompany.DataAccess.DataAccess;
using TourCompany.Models.Models;

namespace TourCompany.Pages.Admin.Tours
{
    public class IndexModel : PageModel
    {
        private readonly TourDBContext _dbContext;
        public IEnumerable<Tour> Tours;
        public IndexModel(TourDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task OnGetAsync()
        {
            Tours = await _dbContext.Tours.ToListAsync();
        }
    }
}
