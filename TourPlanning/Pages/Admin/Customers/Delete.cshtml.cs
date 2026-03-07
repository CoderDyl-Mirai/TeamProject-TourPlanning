using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TourCompany.Models.Models;
using TourCompany.Services;

namespace TourCompany.Pages.Admin.Customers
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;


        public DeleteModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Customer Customer { get; set; }


        public void OnGet(string id)
        {
            Customer = _unitOfWork.CustomerRepository.Get(id);

            if (Customer == null)
            {
                NotFound();
            }

        }

        public IActionResult OnPost()
        {
            var customerFromDB = _unitOfWork.CustomerRepository.Get(Customer.Id);

            if (customerFromDB == null)
            {
                return NotFound();
            }

            _unitOfWork.CustomerRepository.Delete(customerFromDB);
            _unitOfWork.Save();

            return RedirectToPage("Index");
        }

    }
}
