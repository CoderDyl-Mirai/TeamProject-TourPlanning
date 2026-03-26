using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Models.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public string Status {  get; set; } = string.Empty;

        [Required]
        public int TicketAmount { get; set; }

        [Range(0.01, 500, ErrorMessage = "Price must be between €0.01 and €500.00")]
        [Precision(6, 2)]
        public decimal TotalPrice { get; set; }
        [Required(ErrorMessage = "Date is required")]

        public DateTime Date { get; set; }

        public string? CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int TourId { get; set; }

        [ValidateNever]
        public Tour? Tour { get; set; }

        public List<BookingExtra>? BookingExtras { get; set; }
    }
}
