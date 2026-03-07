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
        private readonly UserManager<IdentityUser> _userManager;


        public DeleteModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IdentityUser Customer { get; set; }


        public async Task<IActionResult> OnGet(string id)
        {
            Customer = await _userManager.FindByIdAsync(id);

            if(Customer == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPost(string id)
        {
            Customer = await _userManager.FindByIdAsync(id);

            if (Customer == null)
            {
                return NotFound();
            }

            await _userManager.DeleteAsync(Customer);

            return RedirectToPage("Index");
        }

    }
}
