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
        [BindProperty]
        public Customer Customer { get; set; }
        public Tour Tour { get; set; }
        public void OnGet(int id)
        {
            //var claimsIdentity = (ClaimsIdentity)User.Identity;
            //var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            Booking = new()
            {
                //ApplicationUserId = claim.Value,
                TotalPrice = 0,
                TicketAmount = 0,
                Tour = _unitOfWork.TourRepository.Get(id),
                TourId = id
            };

            Customer = new()
            {
                //ApplicationUserId = claim.Value,
                Firstname = "",
                Lastname = "",
                Email = "",
            };
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {                
                    _unitOfWork.BookingRepository.Add(Booking);
                _unitOfWork.CustomerRepository.Add(Customer);
                _unitOfWork.Save();

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
                              Name = "Sweeneys"
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



                //return RedirectToPage("Index");

            }
            return Page();
        }
    }
}
