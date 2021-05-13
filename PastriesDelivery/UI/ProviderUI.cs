using System;
using System.Collections.Generic;

namespace PastriesDelivery
{
    public class ProviderUI
    {
        private readonly IStorage _storage;

        public ProviderUI(IStorage storage)
        {
            _storage = storage;
        }

        public Pastry AcceptData(Pastry pastry)
        {
            Console.WriteLine();
            pastry.Id = SetId() + 1;
            pastry.Name = Console.ReadLine();
            pastry.Type = Console.ReadLine();
            pastry.Weight = Convert.ToInt32(Console.ReadLine());
            pastry.Price = Convert.ToDecimal(Console.ReadLine());
            pastry.Amount = Convert.ToInt32(Console.ReadLine());
            return pastry;
        }

        private int SetId()
        {
            int id = default;
            for (int i = 0; i < _storage.Pastries.Count; i++)
            {
                if (_storage.Type[i] == StorageType.AvailableProducts)
                {
                    var pastry = _storage.Pastries[i];

                    if (i < pastry.Id)
                    {
                        id = pastry.Id;
                    }
                }
            }
            return id;
        }

        public string ConfirmOffer()
        {
            Messenger.ShowConfirmMessage();
            var answer = Console.ReadLine();
            return answer;
        }
    }
}