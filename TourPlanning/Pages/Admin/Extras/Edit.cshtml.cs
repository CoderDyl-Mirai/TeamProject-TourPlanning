using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourCompany.Models.Models;
using TourCompany.Services;

namespace TourCompany.Pages.Admin.Extras
{
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public EditModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Extra Extra { get; set; }
        public void OnGet(int id)
        {
            Extra = _unitOfWork.ExtraRepository.Get(id);
        }

        public IActionResult OnPost(Extra Extra)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ExtraRepository.Update(Extra);
                _unitOfWork.Save();
            }

            return RedirectToPage("Index");
        }
    }
}