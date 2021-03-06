using System;

namespace EntityFrameworkTask.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Product Product { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderTime { get; set; }
        public OrderStatus Status { get; set; }
        public int DeliveryDays { get; set; }
        public Courier Courier { get; set; }
        public decimal DeliveryPrice { get; set; }
        public DateTime DeliveryTimeEstimated { get; set; }
    }
}