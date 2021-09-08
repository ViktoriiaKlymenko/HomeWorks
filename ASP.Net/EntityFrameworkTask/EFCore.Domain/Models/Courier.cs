using System.Collections.Generic;

namespace EntityFrameworkTask
{
    public class Courier : User
    {
        public decimal Salary { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}