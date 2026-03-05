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
    }
}
