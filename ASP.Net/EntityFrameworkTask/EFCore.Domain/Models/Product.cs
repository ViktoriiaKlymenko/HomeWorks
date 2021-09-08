using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTask
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public double Weight { get; set; }
        public Category Category { get; set; }
        public Provider Provider { get; set; }
        public List<Order> Orders = new List<Order>();
    }
}
