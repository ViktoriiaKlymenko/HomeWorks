using System;

namespace PastriesDelivery
{
    internal class CustomerUI : IDataDisplayer
    {
        protected readonly ICustomerManager Manager;

        public CustomerUI(ICustomerManager manager)
        {
            Manager = manager;
        }

        public void DisplayAvailableProducts()
        {
            var products = Manager.ExtractProducts();

            foreach (var product in products)
            {
                Console.WriteLine("Pastry Id: " + product.Pastry.Id);
                Console.WriteLine("Pastry name: " + product.Pastry.Name);
                Console.WriteLine("Pastry type: " + product.Pastry.Type);
                Console.WriteLine("Pastry weight: " + product.Pastry.Weight + " gr");
                Console.WriteLine("Pastry price: " + product.Pastry.Price + " UAH");
                Console.WriteLine("Pastry amount: " + product.Pastry.Amount);
            }
        }

        internal void DisplayOrder(Order order)
        {
            Console.WriteLine("Pastry name: " + order.Pastry.Name);
            Console.WriteLine("Pastry type: " + order.Pastry.Type);
            Console.WriteLine("Pastry weight: " + order.Pastry.Weight + " gr");
            Console.WriteLine("Pastry amount: " + order.Pastry.Amount);
            Console.WriteLine("Pastry price in UAH: " + order.TotalPrice);
            Console.WriteLine("Pastry price in USD:" + Manager.ConvertToUSD(order.TotalPrice));
        }
    }
}