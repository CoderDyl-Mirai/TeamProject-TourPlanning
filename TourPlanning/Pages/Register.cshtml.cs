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
        private readonly TourDBContext _createCustomer;


        public Register Register {  get; set; }

        public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, TourDBContext createCustomer)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _createCustomer = createCustomer;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = Register.EmailAddress,
                    Email = Register.EmailAddress
                };

                var result = await _userManager.CreateAsync(user, Register.Password);
                if (result.Succeeded)
                {
                    var customer = new Customer
                    {
                        IdentityUserId = user.Id,
                        Firstname = Register.Firstname,
                        Lastname = Register.Lastname,
                        Phone = Register.Phone,
                        Email = Register.EmailAddress
                    };
                    
                    _createCustomer.Customers.Add(customer);
                    await _createCustomer.SaveChangesAsync();
                    
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
