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
                Console.WriteLine("Pastry Id: " + product.Id);
                Console.WriteLine("Pastry name: " + product.Name);
                Console.WriteLine("Pastry weight: " + product.Weight + " gr");
                Console.WriteLine("Pastry price: " + product.Price + " USD");
                Console.WriteLine("Pastry amount: " + product.Amount);
            }
        }
    }
}