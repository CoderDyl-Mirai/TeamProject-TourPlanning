using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripe.Checkout;
using System;
using TourCompany.Models.Models;
using TourCompany.Services;

namespace TourCompany.Pages.Customers.Home
{
    public class SummaryModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public SummaryModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Booking Booking { get; set; }
        public string PaymentStatus { get; set; } = "unknown";

        public IActionResult OnGet(int bookingId, string session_id = null)
        {
            Booking = _unitOfWork.BookingRepository.SummaryDetails(bookingId);
            if (Booking == null)
                return NotFound();

            if (!string.IsNullOrEmpty(session_id))
            {
                try
                {
                    var service = new SessionService();
                    var session = service.Get(session_id);
                    PaymentStatus = session.PaymentStatus ?? "unknown";
                }
                catch (Exception)
                {
                    PaymentStatus = "could-not-verify";
                }
            }

            return Page();
        }
    }
}