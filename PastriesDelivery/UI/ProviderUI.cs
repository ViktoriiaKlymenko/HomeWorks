using System;
using System.Collections.Generic;

namespace PastriesDelivery
{
    public class ProviderUI
    {
        private readonly static IList<Pastry> _availableProducts = new List<Pastry>();

        public ProviderUI(Storage storage)
        {
            for (int i = 0; i < storage.Pastries.Count; i++)
            {
                if (storage.Type[i] == StorageType.AvailableProducts)
                {
                    _availableProducts.Add(storage.Pastries[i]);
                }
            }
        }

        public Pastry AcceptData(Pastry pastry)
        {
            int id = 0;
            Console.WriteLine();
            pastry.Id = SetId(id) + 1;
            pastry.Name = Console.ReadLine();
            pastry.Type = Console.ReadLine();
            pastry.Weight = Convert.ToInt32(Console.ReadLine());
            pastry.Price = Convert.ToDecimal(Console.ReadLine());
            pastry.Amount = Convert.ToInt32(Console.ReadLine());

            return pastry;
        }

        private static int SetId(int i)
        {
            foreach (var product in _availableProducts)
            {
                if (i < product.Id)
                {
                    i = product.Id;
                }
            }
            return i;
        }

        public string ConfirmOffer()
        {
            Messenger.ShowConfirmMessage();
            var answer = Console.ReadLine();
            return answer;
        }
    }
}