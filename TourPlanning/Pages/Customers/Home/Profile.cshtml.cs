using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourCompany.Models.Models;
using TourCompany.Services;

namespace TourCompany.Pages.Customers.Home
{
    [BindProperties]
    public class ProfileModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProfileModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Customer Customer { get; set; }
        public void OnGet()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userid = claim.Value;

            Customer = _unitOfWork.CustomerRepository.Get(userid);
        }
        public IActionResult OnPost()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userid = claim.Value;

            Customer = _unitOfWork.CustomerRepository.Get(userid);


            if (ModelState.IsValid)
            {
                _unitOfWork.CustomerRepository.Update(Customer);
                _unitOfWork.Save();
            }
            return RedirectToPage("Index");
        }
    }
}
