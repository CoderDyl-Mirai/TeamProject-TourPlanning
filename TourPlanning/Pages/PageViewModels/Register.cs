using System.ComponentModel.DataAnnotations;

namespace TourCompany.Pages.PageViewModels
{
    public class Register
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z ]{3,30}$", ErrorMessage = "Firstname can only contain characters")]
        public string Firstname { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z ]{3,30}$", ErrorMessage = "Lastname can only contain characters")]
        public string Lastname { get; set; }

        [Required]
        [RegularExpression(@"^[0][0-9]{9}$", ErrorMessage = "Phone number must be 10 digits. \nStart with a 0 and 2 digits between 6&9")]

        public string Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

    }
}
