using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Models.Models
{
    public class BookingExtra
    {
        [Key]
        public int Id { get; set; }

        [Range(1, 10, ErrorMessage = "Can only book Max 10 tickets")]
        public int Qty { get; set; }

        public int? ExtraId { get; set; }
        public Extra? Extra { get; set; }

        public int? BookingId { get; set; }
        public Booking? Booking { get; set; }
    }
}
