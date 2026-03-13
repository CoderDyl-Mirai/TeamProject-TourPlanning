using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        public BookingExtra BookingExtra { get; set; }
        public Tour Tour { get; set; }
        public IEnumerable<Extra> Extras;
        [BindProperty]

        public IEnumerable<int> choosenExtra { get; set; }
        public void OnGet(int id)
        {
            //var claimsIdentity = (ClaimsIdentity)User.Identity;
            //var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            
            Booking = new()
            {
                //ApplicationUserId = claim.Value,
                TotalPrice = 0,
                TicketAmount = 1,
                Tour = _unitOfWork.TourRepository.Get(id),
                TourId = id,
                Date = DateTime.Now
            };
            Extras = _unitOfWork.ExtraRepository.GetExtrasForTour(id);
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {                
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


                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
