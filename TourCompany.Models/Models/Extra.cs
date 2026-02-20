using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TourCompany.Models.Models
{
    public class Extra
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }

        [Range(0.01, 500, ErrorMessage = "Price must be between €0.01 and €500.00")]
        [Precision(6, 2)]
        public decimal Price { get; set; }

        public int TourId { get; set; }
        public Tour? Tour { get; set; }

        public List<BookingExtra>? BookingExtra { get; set; }
    }
}
