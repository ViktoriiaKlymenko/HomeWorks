using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    public interface ICache
    {
        Queue<Order> Orders { get; set; }
        Queue<Product> Products { get; set; }
    }
}
