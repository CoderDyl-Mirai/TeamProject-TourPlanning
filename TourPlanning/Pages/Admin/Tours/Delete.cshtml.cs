using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourCompany.Models.Models;
using TourCompany.Services;

namespace TourCompany.Pages.Admin.Tours
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public DeleteModel(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public Tour Tour { get; set; }

        public void OnGet(int id)
        {
            Tour = _unitOfWork.TourRepository.Get(id);
        }

        public IActionResult OnPost()
        {
            string wwwRootFolder = _webHostEnvironment.WebRootPath;
            var tourFromDB = _unitOfWork.TourRepository.Get(Tour.Id);

            if (tourFromDB == null)
            {
                return NotFound();
            }

            if (tourFromDB.Image != null && tourFromDB.Image != "")
            {
                var oldFile = Path.Combine(wwwRootFolder, tourFromDB.Image.TrimStart('\\'));
                if (System.IO.File.Exists(oldFile))
                {
                    System.IO.File.Delete(oldFile);
                }
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.TourRepository.Delete(tourFromDB);
                _unitOfWork.Save();
            }

            return RedirectToPage("Index");
        }
    }
}

