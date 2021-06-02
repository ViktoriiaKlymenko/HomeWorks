using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
=======

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for work with consumer interface.
    /// </summary>
>>>>>>> abde3cf (Code was improved.)
    internal class CustomerUI : IDataDisplayer
    {
        protected ICustomerManager Manager { get; }

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
<<<<<<< HEAD
}
=======
}
>>>>>>> abde3cf (Code was improved.)
