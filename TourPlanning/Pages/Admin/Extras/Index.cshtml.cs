using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TourCompany.DataAccess.DataAccess;
using TourCompany.Models.Models;

namespace TourCompany.Pages.Admin.Extras
{
    public class IndexModel : PageModel
    {
        private readonly TourDBContext _dbContext;
        public IEnumerable<Extra> Extras;
        public IndexModel(TourDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task OnGetAsync()
        {
            Extras = await _dbContext.Extras.ToListAsync();
        }
    }
}
