using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdModule
{
    public class Order
    {
        public Client Client { get; set; }
        public string DeliveryAdress { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderTime { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DeliveryTime { get; set; }
        public Provider Provider { get; set; }
        public Courier Courier { get; set; }
        public decimal DeliveryPrice { get; set; }
    }
}
