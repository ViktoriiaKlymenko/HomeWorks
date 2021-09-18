using System;

namespace PastriesDelivery
{
    public class Order
    {
        private Guid Id { get; }
        public Pastry Pastry { get; set; }
        public User User { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DeliveryTime { get; set; }

        public Order(Pastry pastry, User user, decimal totalPrice)
        {
            Pastry = pastry;
            User = user;
            TotalPrice = totalPrice;
            Id = Guid.NewGuid();
        }
    }
}