using System.ComponentModel.DataAnnotations;

namespace WebApplicationService.Models
{
    public class ProductViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [Range(0, 999)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 200)]
        public int Amount { get; set; }

        [Required]
        public double Weight { get; set; }

        [Required]
        [Range(1, 3)]
        public int CategoryId { get; set; }

        [Required]
        [Range(1, 3)]
        public int ProviderId { get; set; }
    }
}