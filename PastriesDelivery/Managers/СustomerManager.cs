﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PastriesDelivery
{
    public class СustomerManager
    {
<<<<<<< HEAD
        protected IStorage Storage { get; }
        protected ICurrencyService Converter { get; }

        public СustomerManager(IStorage storage, ICurrencyService converter)
        {
            Storage = storage;
            Converter = converter;
=======
        protected readonly IStorage Storage;
        protected readonly ILogger Logger;

        public СustomerManager(IStorage storage, ILogger logger)
        {
            Storage = storage;
            Logger = logger;
>>>>>>> main
        }

        public Pastry ChooseProduct(int id, int amount)
        {
            var availableProducts = ExtractProducts();
            var pastry = availableProducts.FirstOrDefault(product => product.Pastry.Id == id).Pastry;

            if (amount > pastry.Amount || amount <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (amount < pastry.Amount)
            {
                Storage.Products.FirstOrDefault(product => product.Pastry.Id == id).Pastry.Amount -= amount;
                Logger.Log($"{amount} units of {pastry.ToString()} were removed from available products.");
                return pastry;
            }

            if (pastry.Amount == amount)
            {
                Storage.Products.Remove(availableProducts.FirstOrDefault(product => product.Pastry.Id == id));
                Logger.Log($"{pastry.ToString()} was removed from available products.");
                return pastry;
            }

            return pastry;
        }

        public bool CheckForDataPrescence()
        {
            return Storage.Products.Count is not 0;
        }

        public virtual Order CreateOrder(Pastry pastry, User user)
        {
            var totalPrice = pastry.Price * pastry.Amount;
            Storage.Orders.Add(new Order(pastry, user, totalPrice));
<<<<<<< HEAD
            return Storage.Orders.Last();
=======
            Logger.Log($"{pastry.ToString()} and {user.ToString()} were added to orders.");
>>>>>>> main
        }

        public List<Product> ExtractProducts()
        {
            return Storage.Products;
        }

        public decimal ConvertToUSD(decimal totalPrice)
        {
            var currenciesRate = Converter.DownloadCurrenciesRateAsync().Result;
            var USDRate = currenciesRate.FirstOrDefault(currenciesRate => currenciesRate.CurrencyName == "USD");
            return totalPrice * USDRate.Sale;
        }
    }
}