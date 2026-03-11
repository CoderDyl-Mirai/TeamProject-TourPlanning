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
        public void OnGet(int id)
        {
            Customer = _unitOfWork.CustomerRepository.Get(id);
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CustomerRepository.Update(Customer);
                _unitOfWork.Save();
            }
            return RedirectToPage("Index");
        }
    }
}
