using System.Collections.Generic;

namespace PastriesDelivery
{
    public class Storage : IStorage
    {
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }

        public Storage()
        {
            Products = new List<Product>();
            Orders = new List<Order>();
        }
    }
}