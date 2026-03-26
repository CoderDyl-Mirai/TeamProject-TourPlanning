using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourCompany.Models.Models;
using TourCompany.Services;

namespace TourCompany.Pages.Customers.Home
{
    [BindProperties]
    public class BookingHistoryModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<Booking> Booking;
        public BookingHistoryModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userid = claim.Value;

            Booking = _unitOfWork.BookingRepository.BookingDetails(userid);

            foreach (var booking in Booking)
            {
                if (booking.Date < DateTime.Now && booking.Status == "Confirmed")
                {
                    booking.Status = "Completed";
                }
            }
            _unitOfWork.Save();
        }

        public IActionResult OnPost(int id)
        {
            if (ModelState.IsValid)
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                var userid = claim.Value;

                var booking = _unitOfWork.BookingRepository.BookingDetails(userid).FirstOrDefault(b => b.Id == id);

                if(booking.Status != "Completed" && booking.Status != "Cancelled")
                {
                    booking.Status = "Cancelled";
                    _unitOfWork.BookingRepository.Update(booking);
                    _unitOfWork.Save();
                }

            }
            return RedirectToPage("BookingHistory");
        }
    }
}
