using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TourCompany.DataAccess.Repository;
using TourCompany.Models.Models;
using TourCompany.Services;

namespace TourCompany.Pages.Admin.Bookings
{

    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CreateModel(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _unitOfWork = unitOfWork;
        }
        [BindProperty]
        public Booking Booking { get; set; }

        public IActionResult OnPost(Booking booking)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.BookingRepository.Add(booking);
                _unitOfWork.Save();
            }
            return RedirectToPage("Index");
        }
    }
}
