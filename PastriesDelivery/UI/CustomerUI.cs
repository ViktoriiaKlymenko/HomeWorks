using System;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for work with consumer interface.
    /// </summary>
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
                Console.WriteLine("Pastry price: " + product.Pastry.Price + " USD");
                Console.WriteLine("Pastry amount: " + product.Pastry.Amount);
            }
        }
    }
}