using System;
using System.Collections.Generic;
using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class ConsumerManager : IOrderMaker
    {
        private readonly IList<Pastry> _availableProducts;

        public ConsumerManager(IStorage storage)
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

        public bool CheckForDataPrescence()
        {
            if (_availableProducts.Count == 0)
            {
                return false;
            }
            return true;
        }

        public Pastry ChooseProduct(string idAndAmount, Storage storage)
        {
            var pastry = new Pastry();
            var id = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]);
            var amount = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);

            foreach (var product in _availableProducts)
            {
                if (id == product.Id)
                {
                    pastry = product;
                    RemoveFromAvailableProducts(amount, product, storage);
                }
            }
            return pastry;
        }

        private void RemoveFromAvailableProducts(int amount, Pastry product, Storage storage)
        {
            foreach (var pastry in storage.Pastries)
            {
                if (pastry == product)
                {
                    if (amount == product.Amount)
                    {
                        storage.Pastries.Remove(product);
                    }
                    if (amount < product.Amount)
                    {
                        pastry.Amount -= amount;
                    }
                }
            }
        }

        public Storage SendOrderToStorage(Storage storage, Pastry pastry)
        {
            storage.Pastries.Add(pastry);
            storage.Type.Add(StorageType.UserOrders);

            return storage;
        }

        public Storage SendUserToStorage(Storage storage, User consumer)
        {
            storage.Users.Add(consumer);
            return storage;
        }
    }
}