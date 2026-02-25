using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TourCompany.Models.Models;

namespace TourCompany.Pages.Admin.Tours
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CreateModel(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _unitOfWork = unitOfWork;
        }

        public Tour Tour { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            string wwwRootFolder = _webHostEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            string new_filename = Guid.NewGuid().ToString();

            var upload = Path.Combine(wwwRootFolder, @"Images\Tours");

            var extension = Path.GetExtension(files[0].FileName);
            using (var fileStream = new FileStream(Path.Combine(upload, new_filename + extension), FileMode.Create))
            {
                files[0].CopyTo(fileStream);
            }

            Tour.Image = @"\Images\Tours\" + new_filename + extension;
            if (ModelState.IsValid)
            {
                _unitOfWork.TourRepo.Add(Tour);
                _unitOfWork.Save();
            }
            return RedirectToPage("Index");
        }
    }
}
