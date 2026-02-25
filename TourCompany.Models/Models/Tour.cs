using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TourCompany.Models.Models
{
    public class Tour
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [Range(0.01, 500, ErrorMessage = "Price must be between €0.01 and €500.00")]
        [Precision(6, 2)]
        public decimal Price { get; set; }

        public string? Image { get; set; }

        public int MaxCapacity { get; set; }

        public int MinCapacity { get; set; }


        public int Duration { get; set; }

        public DateTime Date { get; set; }

        public string? Location { get; set; }
        public List<Booking>? Bookings { get; set; }
        public List<Extra>? Extras { get; set; }
    }
}
