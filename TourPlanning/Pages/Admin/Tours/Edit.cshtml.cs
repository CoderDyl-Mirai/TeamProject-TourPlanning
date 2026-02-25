using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TourCompany.Models.Models;
using TourCompany.Services;

namespace TourCompany.Pages.Admin.Tours
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EditModel(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
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
            var files = HttpContext.Request.Form.Files;
            var tourFromDB = _unitOfWork.TourRepository.Get(Tour.Id);

            if (files.Count > 0)
            {

                string new_filename = Guid.NewGuid().ToString();

                var upload = Path.Combine(wwwRootFolder, @"Images\Tours");

                var extension = Path.GetExtension(files[0].FileName);
                if (tourFromDB != null)
                {
                    var oldFile = Path.Combine(wwwRootFolder, tourFromDB.Image.TrimStart('\\'));
                    if (System.IO.File.Exists(oldFile))
                    {
                        System.IO.File.Delete(oldFile);
                    }
                }

                using (var fileStream = new FileStream(Path.Combine(upload, new_filename + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                Tour.Image = @"\Images\Tours\" + new_filename + extension;


            }

            if (ModelState.IsValid)
            {

                _unitOfWork.TourRepository.Update(Tour);
                _unitOfWork.Save();
            }
            return RedirectToPage("Index");
        }
    }
}
