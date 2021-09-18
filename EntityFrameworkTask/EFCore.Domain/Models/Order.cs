using System;

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
        public DateTime DeliveryTimeEstimated { get; set; }

        public Order()
        {
            DeliveryTimeEstimated = OrderTime.AddDays(3);
        }
    }
}