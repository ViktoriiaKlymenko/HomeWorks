using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkTask.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [Range(0, 999)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 999)]
        public int Amount { get; set; }

        [Required]
        [Range(0, 10)]
        public double Weight { get; set; }

        public Category Category { get; set; }
        public Provider Provider { get; set; }
    }
}