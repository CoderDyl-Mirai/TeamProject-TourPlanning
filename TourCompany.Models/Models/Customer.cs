using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TourCompany.Models.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string? IdentityUserId { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z ]{3,30}$", ErrorMessage = "Firstname can only contain characters")]
        public string? Firstname { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z ]{3,30}$", ErrorMessage = "Lastname can only contain characters")]
        public string? Lastname { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9!$%&#_-]+@[a-zA-Z]+\.[a-zA-Z]{2,3}$", ErrorMessage = "Invalid Email")]
        public string? Email { get; set; }

        [RegularExpression(@"^[0][0-9]{9}$", ErrorMessage = "Phone number must be 10 digits. \nStart with a 0 and 2 digits between 6&9")]
        public string? Phone { get; set; }

        [RegularExpression(@"^[0-9]{16}$", ErrorMessage = "Credit Card number must be 16 digits.")]
        public string? CreditCardNum { get; set; }

        public DateOnly? ExpiryDate { get; set; }

        [Range(100, 999, ErrorMessage = "CSV must be 3 digits")]
        public int? CSV { get; set; }

        public List<Booking>? Bookings { get; set; }

    }
}
