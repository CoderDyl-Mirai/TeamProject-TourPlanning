using System.ComponentModel.DataAnnotations;

namespace TourCompany.Models
{
    public class Plan
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
