using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Models.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Firstname { get; set; }

        [Required]
        public string? Lastname { get; set; }

        [Required]
        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? CreditCardNum { get; set; }

        public DateOnly ExpiryDate { get; set; }

        public int CSV { get; set; }

        public List<Booking>? Bookings { get; set; }

    }
}
