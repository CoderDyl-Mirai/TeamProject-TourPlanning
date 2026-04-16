using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripe.Checkout;
using System;
using System.Security.Claims;
using TourCompany.Models.Models;
using TourCompany.Services;

namespace TourCompany.Pages.Customers.Home
{
    public class BookingModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingModel(IUnitOfWork unitofWork)
        {
            _unitOfWork = unitofWork;
        }

        [BindProperty]
        public Booking Booking { get; set; }
        [BindProperty]
        public Customer Customer { get; set; }
        public Tour Tour { get; set; }
        public void OnGet(int id)
        {
            Booking = new()
            {
                TotalPrice = 0,
                TicketAmount = 0,
                Tour = _unitOfWork.TourRepository.Get(id),
                TourId = id
            };

            Customer = new()
            {
                Firstname = "",
                Lastname = "",
                Email = "",
            };
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _unitOfWork.BookingRepository.Add(Booking);
            _unitOfWork.CustomerRepository.Add(Customer);
            _unitOfWork.Save(); 

            var domain = "https://localhost:7201";
            var successUrl = $"{domain}/Customers/Home/Summary?bookingId={Booking.Id}&session_id={{CHECKOUT_SESSION_ID}}";
            var cancelUrl = $"{domain}/Customers/Home/Booking?id={Booking.TourId}";

            var unitAmountCents = Convert.ToInt64(Math.Round(Booking.TotalPrice * 100m));

            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
                {
                  new SessionLineItemOptions
                  {
                      PriceData= new SessionLineItemPriceDataOptions
                      {
                          UnitAmount = unitAmountCents,
                          Currency="eur",
                          ProductData = new SessionLineItemPriceDataProductDataOptions
                          {
                              Name = Booking.Tour?.Name ?? "Tour booking"
                          }
                      },
                      Quantity = Booking.TicketAmount > 0 ? Booking.TicketAmount : 1,
                  },
                },
                PaymentMethodTypes = new List<string> { "card" },
                Mode = "payment",
                SuccessUrl = successUrl,
                CancelUrl = cancelUrl,
            };

            var service = new SessionService();
            Session session;
            try
            {
                session = service.Create(options);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Could not create Stripe Checkout session: " + ex.Message);
                return Page();
            }

            if (!string.IsNullOrEmpty(session.Url))
            {
                return Redirect(session.Url);
            }

            ModelState.AddModelError(string.Empty, "Stripe returned an empty session URL.");
            return Page();
        }
    }
}