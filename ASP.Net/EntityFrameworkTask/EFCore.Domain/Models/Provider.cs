using System.Collections.Generic;

namespace EntityFrameworkTask.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public ProviderType Type { get; set; }
        public string Name { get; set; }
        public List<Product> Products = new List<Product>();
    }
}