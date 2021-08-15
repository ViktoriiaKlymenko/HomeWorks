using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTask
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderTime { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DeliveryTime { get; set; }
        public int CourierId { get; set; }
        public decimal DeliveryPrice { get; set; }
    }
}
