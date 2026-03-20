using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TourCompany.Models.Models
{
    public class Customer : IdentityUser
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z ]{3,30}$", ErrorMessage = "Firstname can only contain characters")]
        public string? Firstname { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z ]{3,30}$", ErrorMessage = "Lastname can only contain characters")]
        public string? Lastname { get; set; }

        [RegularExpression(@"^[0-9]{16}$", ErrorMessage = "Credit Card number must be 16 digits.")]

        public List<Booking>? Bookings { get; set; }

    }
}
