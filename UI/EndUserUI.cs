using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    class EndUserUI : ConsumerUI, IDataDisplayer
    {
        /// <summary>
        /// This class describes methods intended for work with end-user interface.
        /// </summary>
        public void DisplayAvailableProducts()
        {
            foreach (var product in AvailableProducts.Products)
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
