using System;
using System.Collections.Generic;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for work with consumer interface.
    /// </summary>
    internal class CustomerUI : IDataDisplayer
    {
        protected ICustomerManager Manager { get; }
        protected ICurrencyConverter Converter { get; }
        protected static IList<Currency> CurrenciesRate { get; set; }

        static CustomerUI()
        {
            CurrenciesRate = CurrencyConverter.DownloadCurrenciesRateAsync().GetAwaiter().GetResult();
        }

        public CustomerUI(ICustomerManager manager, ICurrencyConverter converter)
        {
            Manager = manager;
            Converter = converter;
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
            Console.WriteLine("Pastry price in USD:" + Converter.ConvertToUSD(order.TotalPrice, CurrenciesRate));
        }
    }
}