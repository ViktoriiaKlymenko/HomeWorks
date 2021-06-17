using System.Collections.Generic;

namespace PastriesDelivery
{
    public class Storage : IStorage
    {
<<<<<<< HEAD
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }

        public Storage()
        {
            Orders = new List<Order>();
            Products = new List<Product>();
=======
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }

        public Storage()
        {
            Products = new List<Product>();
            Orders = new List<Order>();
>>>>>>> main
        }
    }
}