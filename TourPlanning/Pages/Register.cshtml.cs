using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourCompany.DataAccess.DataAccess;
using TourCompany.Models.Models;
using TourCompany.Pages.PageViewModels;

namespace TourCompany.Pages
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public Register Register {  get; set; }


        public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var user = new Customer()
                {
                    UserName = Register.EmailAddress,
                    Firstname = Register.Firstname,
                    Lastname = Register.Lastname,
                    PhoneNumber = Register.Phone,
                    Email = Register.EmailAddress,
                    
                };

                var result = await _userManager.CreateAsync(user, Register.Password);
                if (result.Succeeded)
                {  
                    await _userManager.AddToRoleAsync(user, "Customer");
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }

                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }
            return Page();
        }
    }
}
