using System.Collections.Generic;

namespace PastriesDelivery
{
    public class Storage : IStorage
    {
<<<<<<< HEAD
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }

        public Storage()
        {
            Products = new List<Product>();
            Orders = new List<Order>();
=======
        public StorageType Type { get; set; }
        public List<Pastry> Pastries { get; set; }
        public List<User> Users { get; set; }

        public Storage()
        {
            Pastries = new List<Pastry>();
            Users = new List<User>();
>>>>>>> 6503217 (Code was improved.)
        }
    }
}