using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourCompany.Models.Models;
using TourCompany.Services;

namespace TourCompany.Pages.Admin.Extras
{
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [BindProperty]
        public Extra Extra { get; set; }
        public void OnGet(int id)
        {
            Extra = _unitOfWork.ExtraRepository.Get(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ExtraRepository.Delete(Extra);
                _unitOfWork.Save();
            }

            return RedirectToPage("Index");
        }
    }
}
