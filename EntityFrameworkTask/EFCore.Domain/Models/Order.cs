using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> Task4-APILayer

namespace EntityFrameworkTask
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
<<<<<<< HEAD
        public decimal TotalPrice { get; set; }
        public DateTime OrderTime { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DeliveryTime { get; set; }
        public int CourierId { get; set; }
        public decimal DeliveryPrice { get; set; }
        public DateTime DeliveryTimeEstimated { get; set; }

        public Order()
        {
            DeliveryTimeEstimated = OrderTime.AddDays(3);
        }
    }
}
=======
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderTime { get; set; }
        public OrderStatus Status { get; set; }
        public int DeliveryDays { get; set; }
        public int CourierId { get; set; }
        public decimal DeliveryPrice { get; set; }
        public DateTime DeliveryTimeEstimated { get; set; }
        public Order(int id, int clientId, int productId, int amount, decimal totalPrice, int courierId)
        {
            Id = id;
            ClientId = clientId;
            ProductId = productId;
            Amount = amount;
            TotalPrice = totalPrice;
            OrderTime = new DateTime();
            DeliveryDays = 3;
            Status = OrderStatus.Ordered;
            CourierId = courierId;
            DeliveryPrice = 30;
            DeliveryTimeEstimated = OrderTime.AddDays(DeliveryDays);
        }
    }
}
>>>>>>> Task4-APILayer
