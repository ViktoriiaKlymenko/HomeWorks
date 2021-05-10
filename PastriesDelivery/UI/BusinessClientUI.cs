using System;
using System.Collections.Generic;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for work with business client interface.
    /// </summary>
    internal class BusinessClientUI : IDataDisplayer
    {
        private readonly IList<Pastry> _availableProducts = new List<Pastry>();

        public BusinessClientUI(IStorage storage)
        {
            _availableProducts = new List<Pastry>();
            for (int i = 0; i < storage.Pastries.Count; i++)
            {
                if (storage.Type[i] == StorageType.AvailableProducts)
                {
                    _availableProducts.Add(storage.Pastries[i]);
                }
            }
        }

        public void DisplayAvailableProducts()
        {
            foreach (var product in _availableProducts)
            {
                Console.WriteLine("Pastry Id: " + product.Id);
                Console.WriteLine("Pastry name: " + product.Name);
                Console.WriteLine("Pastry weight: " + product.Type);
                Console.WriteLine("Pastry weight: " + product.Weight + " gr");
                Console.WriteLine("Pastry weight: " + product.Price + " USD");
                Console.WriteLine("Pastry weight: " + product.Amount);
            }
        }

        public static string GetAddress()
        {
            string address;
            address = Console.ReadLine();
            return address;
        }

        public static string GetPhoneNumber()
        {
            string phoneNumber;
            phoneNumber = Console.ReadLine();
            return phoneNumber;
        }

        public static string GetOrder()
        {
            return Console.ReadLine();
        }

        public string ConfirmOrder()
        {
            var answer = Console.ReadLine();
            return answer;
        }
    }
}