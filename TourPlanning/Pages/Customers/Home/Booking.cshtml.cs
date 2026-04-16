using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripe.Checkout;
using Stripe.Climate;
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
        public BookingExtra BookingExtra { get; set; }
        public Tour Tour { get; set; }

        public object BookingsOfTour;
        public IEnumerable<Extra> Extras;
        [BindProperty]

        public IEnumerable<int> choosenExtra { get; set; }
        public void OnGet(int id)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            
            Booking = new()
            {
                CustomerId = claim.Value,
                TotalPrice = 0,
                TicketAmount = 1,
                Tour = _unitOfWork.TourRepository.Get(id),
                TourId = id,
                Date = DateOnly.FromDateTime(DateTime.Now),
                Time = "0:00"
            };
            Extras = _unitOfWork.ExtraRepository.GetExtrasForTour(id);

            BookingsOfTour = _unitOfWork.BookingRepository.GetBookingsOfTour(id);

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Booking.Status = "Confirmed";
                _unitOfWork.BookingRepository.Add(Booking);

                _unitOfWork.Save();
                
                foreach (var extra in choosenExtra)
                {
                    BookingExtra = new BookingExtra()
                    {
                        Qty = Booking.TicketAmount,
                        ExtraId = extra,
                        BookingId = Booking.Id
                    };

                    _unitOfWork.BookingExtraRepository.Add(BookingExtra);
                    _unitOfWork.Save();
                }

                var domain = "https://localhost:7201";
                var options = new SessionCreateOptions
                {
                    LineItems = new List<SessionLineItemOptions>
                {
                  new SessionLineItemOptions
                  {
                      PriceData= new SessionLineItemPriceDataOptions
                      {
                          UnitAmount = (long)(Booking.TotalPrice *100),
                          Currency="eur",
                          ProductData = new SessionLineItemPriceDataProductDataOptions
                          {
                              Name = "Terrific Tours"
                          }
                      },

                    Quantity = 1,
                  },
                },
                    PaymentMethodTypes = new List<string>
                {
                    "card",
                },

                    Mode = "payment",
                    SuccessUrl = domain + "/Customers/Home",
                    CancelUrl = domain + "/Customers/Home",
                };
                var service = new SessionService();
                Session session = service.Create(options);

                Response.Headers.Add("Location", session.Url);
                return new StatusCodeResult(303);

                


            }
            return RedirectToPage("Index");
        }
    }
}
