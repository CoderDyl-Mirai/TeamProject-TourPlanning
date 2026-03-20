using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourCompany.Models.Models;
using TourCompany.Services;

namespace TourCompany.Pages.Customers.Home
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitofWork;

        public IndexModel(IUnitOfWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public IEnumerable<Tour> listOfTours {  get; set; }
        public IEnumerable<Extra> Extras { get; set; }
        [BindProperty(SupportsGet =true)]

        public string? SearchString { get; set; }
        public void OnGet()
        {
            listOfTours = _unitofWork.TourRepository.GetAll();
            Extras = _unitofWork.ExtraRepository.GetAll();
            if(!string.IsNullOrEmpty(SearchString))
            {
                listOfTours = listOfTours.Where(t => t.Name.Contains(SearchString, StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}
