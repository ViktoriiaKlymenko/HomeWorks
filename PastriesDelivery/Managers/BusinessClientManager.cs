﻿using System;
using System.Collections.Generic;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with business client.
    /// </summary>
    public class BusinessClientManager : IOrderMaker
    {
        private readonly IList<Pastry> _availableProducts = new List<Pastry>();

        public BusinessClientManager(IStorage storage)
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
            if (_availableProducts.Count is 0)
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

        public Storage SendOrderToStorage(Storage businessClientStorage, Pastry pastry)
        {
            pastry.Price *= pastry.Amount;
            ApplyDiscount(pastry);
            businessClientStorage.Pastries.Add(pastry);
            return businessClientStorage;
        }

        public Storage SendUserToStorage(Storage businessClientStorage, User businessClient)
        {
            businessClientStorage.Users.Add(businessClient);
            return businessClientStorage;
        }

        private static Pastry ApplyDiscount(Pastry product)
        {
            if (product.Amount > 19 && product.Amount < 50)
            {
                product.Price -= product.Price / 100 * (int)DiscountPercents.TwentyUnits;
            }
            if (product.Amount > 49 && product.Amount < 100)
            {
                product.Price -= product.Price / 100 * (int)DiscountPercents.FiftyUnits;
            }
            if (product.Amount > 99)
            {
                product.Price -= product.Price / 100 * (int)DiscountPercents.HundredUnits;
            }
            return product;
        }
    }
}