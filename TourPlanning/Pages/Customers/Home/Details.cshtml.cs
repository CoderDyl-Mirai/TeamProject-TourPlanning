using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;
using TourCompany.Models.Models;
using TourCompany.Services;

namespace TourCompany.Pages.Customers.Home
{
    public class DetailsModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public DetailsModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }   
        public Tour Tour { get; set; }
        public void OnGet(int id)
        {
            Tour = _unitOfWork.TourRepository.Get(id);
        }
    }
}
