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
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderTime { get; set; }
        public OrderStatus Status { get; set; }
        public int DeliveryDays { get; set; }
        public int CourierId { get; set; }
        public decimal DeliveryPrice { get; set; }
        public DateTime DeliveryTimeEstimated { get; set; }
        public Order(int clientId, int productId, int amount, decimal totalPrice, int courierId)
        {
            Id = new int();
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
