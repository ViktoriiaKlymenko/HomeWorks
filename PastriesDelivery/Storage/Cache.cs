using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    public class Cache: ICache
    {
        public Queue<Order> Orders { get; set; }
        public Queue<Product> Products { get; set; }

        public Cache()
        {
            Orders = new Queue<Order>();
            Products = new Queue<Product>();           
        }
    }
}
