using System;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for work with end-user interface.
    /// </summary>
    internal class EndUserUI : ConsumerUI, IDataDisplayer
    {
        private readonly AvailableProducts _availableProducts;
        public EndUserUI(AvailableProducts availableProducts)
        {
            _availableProducts = availableProducts;
        }       

        public void DisplayAvailableProducts()
        {

            foreach (var product in _availableProducts.Products)
            {
                Console.WriteLine("Pastry Id: " + product.Id);
                Console.WriteLine("Pastry name: " + product.Name);
                Console.WriteLine("Pastry type: " + product.Type);
                Console.WriteLine("Pastry weight: " + product.Weight + " gr");
                Console.WriteLine("Pastry price: " + product.Price + " USD");
                Console.WriteLine("Pastry amount: " + product.Amount);
            }
        }

        public void DisplayProviderData()
        {
            Console.WriteLine("Company name: " + Provider.Name);
            Console.WriteLine("Company adress: " + Provider.Adress);
            Console.WriteLine("Company phone number: " + Provider.PhoneNumber);
        }
    }
}