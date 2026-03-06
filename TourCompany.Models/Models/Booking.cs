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
<<<<<<< HEAD
        public int TourId { get; set; }
        [ForeignKey("TourId")]
        [ValidateNever]
        public Tour Tour { get; set; }
        public int TicketAmount {  get; set; }
        public decimal TotalPrice { get; set; }
        //public string CustomerId { get; set; }
        //[ForeignKey("CustomerId")]
        //[ValidateNever]

        //public Customer Customer { get; set; }
=======
        [Required]
        public int TicketAmount { get; set; }

        [Range(0.01, 500, ErrorMessage = "Price must be between €0.01 and €500.00")]
        [Precision(6, 2)]
        public decimal TotalPrice { get; set; }

        public DateTime Date { get; set; }

        public string? CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int TourId { get; set; }
        public Tour? Tour { get; set; }
        public List<BookingExtra>? BookingExtras { get; set; }
>>>>>>> f019fff7399e40ec9563383755cee9a983ae1d77
    }
}
