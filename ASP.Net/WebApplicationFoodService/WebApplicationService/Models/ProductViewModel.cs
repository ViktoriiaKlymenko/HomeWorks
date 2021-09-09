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

        public double Weight { get; set; }
        public int CategoryId { get; set; }
        public int ProviderId { get; set; }
    }
}