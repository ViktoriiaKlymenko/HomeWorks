using System;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for work with business client interface.
    /// </summary>
    internal class BusinessClientUI : IDataDisplayer
    {
        private readonly ICustomerManager _manager;

        public BusinessClientUI(ICustomerManager manager)
        {
            _manager = manager;
        }

        public void DisplayAvailableProducts()
        {
            var products = _manager.ExtractProducts();
            foreach (var product in products)
            {
                Console.WriteLine("Pastry Id: " + product.Pastry.Id);
                Console.WriteLine("Pastry name: " + product.Pastry.Name);
                Console.WriteLine("Pastry weight: " + product.Pastry.Type);
                Console.WriteLine("Pastry weight: " + product.Pastry.Weight + " gr");
                Console.WriteLine("Pastry weight: " + product.Pastry.Price + " USD");
                Console.WriteLine("Pastry weight: " + product.Pastry.Amount);
            }
        }

    }
}