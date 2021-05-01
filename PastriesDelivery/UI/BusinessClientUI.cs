using System;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for work with business client interface.
    /// </summary>
    internal class BusinessClientUI : ConsumerUI, IDataDisplayer
    {
        private readonly AvailableProducts _availableProducts;
        public BusinessClientUI(AvailableProducts availableProducts)
        {
            _availableProducts = availableProducts;
        }
        public void DisplayAvailableProducts()
        {
            foreach (var product in _availableProducts.Products)
            {
                Console.WriteLine("Pastry Id: " + product.Id);
                Console.WriteLine("Pastry name: " + product.Name);
                Console.WriteLine("Pastry weight: " + product.Type);
                Console.WriteLine("Pastry weight: " + product.Weight + " gr");
                Console.WriteLine("Pastry weight: " + product.Price + " USD");
                Console.WriteLine("Pastry weight: " + product.Amount);
            }
        }

        public void DisplayProviderData()
        {
            Console.WriteLine("Company name: " + Provider.Name);
            Console.WriteLine("Company adress: " + Provider.Adress);
            Console.WriteLine("Company phone number: " + Provider.PhoneNumber);
            Console.WriteLine("There are discounts for you.");
            Console.WriteLine("20+ units discount is " + Provider.twentyUnitsDiscount + "%");
            Console.WriteLine("50+ units discount is " + Provider.fiftyUnitsDiscount + "%");
            Console.WriteLine("100+ units discount is " + Provider.hundredUnitsDiscount + "%");
        }
    }
}