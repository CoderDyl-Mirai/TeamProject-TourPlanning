using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TourCompany.DataAccess.DataAccess;
using TourCompany.Models.Models;

namespace TourCompany.Pages.Admin.Customers
{
    public class IndexModel : PageModel
    {
        private readonly TourDBContext _dbContext;
        public IEnumerable<Customer> Customers;
        public IndexModel(TourDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task OnGetAsync()
        {
            Customers = await _dbContext.Customers.ToListAsync();
        }
    }
}
