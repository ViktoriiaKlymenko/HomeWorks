using EFCore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using EntityFrameworkTask;

namespace PastriesDelivery
{
    public class СustomerManager
    {
        protected IUnitOfWork UnitOfWork { get; }
        protected IStorage Storage { get; }
        protected ICurrencyService Converter { get; }

        public СustomerManager(IStorage storage, ICurrencyService converter)
        {
            
            Storage = storage;
            Converter = converter;
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
                return pastry;
            }

            if (pastry.Amount == amount)
            {
                Storage.Products.Remove(availableProducts.FirstOrDefault(product => product.Pastry.Id == id));
                return pastry;
            }

            return pastry;
        }

        public bool CheckForDataPresence()
        {
            return Storage.Products.Count is not 0;
        }

        public virtual Order CreateOrder(Pastry pastry, User user)
        {
            var totalPrice = pastry.Price * pastry.Amount;
            Storage.Orders.Add(new Order(pastry, user, totalPrice));
            return Storage.Orders.Last();
        }

        public List<Product> ExtractProducts()
        {
            return UnitOfWork.Products.GetAll();
        }

        public decimal ConvertToUSD(decimal totalPrice)
        {
            var currenciesRate = Converter.DownloadCurrenciesRateAsync().Result;
            var USDRate = currenciesRate.FirstOrDefault(currenciesRate => currenciesRate.CurrencyName == "USD");
            return totalPrice * USDRate.Sale;
        }
    }
}