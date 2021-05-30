using System.Collections.Generic;

namespace PastriesDelivery
{
    public class Storage : IStorage
    {
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }

        public Storage()
        {
            Orders = new List<Order>();
            Products = new List<Product>();
        }
    }
}