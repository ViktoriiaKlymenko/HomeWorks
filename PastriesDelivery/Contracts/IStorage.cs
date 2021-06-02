using System.Collections.Generic;

namespace PastriesDelivery
{
    public interface IStorage
    {
        List<Product> Products { get; set; }
        List<Order> Orders { get; set; }
    }
}