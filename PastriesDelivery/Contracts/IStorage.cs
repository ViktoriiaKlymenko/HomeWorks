using System.Collections.Generic;

namespace PastriesDelivery
{
    public interface IStorage
    {
<<<<<<< HEAD
        List<Product> Products { get; set; }
        List<Order> Orders { get; set; }
=======
        List<Pastry> Pastries { get; set; }
        StorageType Type { get; set; }
        List<User> Users { get; set; }
>>>>>>> 6503217 (Code was improved.)
    }
}