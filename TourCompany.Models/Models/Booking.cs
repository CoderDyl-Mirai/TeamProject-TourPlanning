using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TourCompany.Models.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public int TicketAmount { get; set; }

        [Range(0.01, 500, ErrorMessage = "Price must be between €0.01 and €500.00")]
        [Precision(6, 2)]
        public decimal TotalPrice { get; set; }

        public DateTime Date { get; set; }

        public string? Email { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int TourId { get; set; }
        public Tour? Tour { get; set; }

        public List<BookingExtra>? BookingExtras { get; set; }
    }
}
