using System;
using System.Collections.Generic;
using System.Linq;

namespace PastriesDelivery
{
    public class СustomerManager
    {
        protected IStorage Storage { get; }

        public СustomerManager(IStorage storage)
        {
            Storage = storage;
        }

        public Pastry ChooseProduct(int id, int amount)
        {
            var availableProducts = ExtractProducts();
            var pastry = availableProducts.FirstOrDefault(product => product.Pastry.Id == id).Pastry;
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

            if (amount > pastry.Amount || amount <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return pastry;
        }

        public bool CheckForDataPrescence()
        {
            if (Storage.Products.Count is 0)
            {
                return false;
            }
            return true;
        }

        public virtual void CreateOrder(Pastry pastry, User user)
        {
            Storage.Orders.Add(new Order(pastry, user, pastry.Price * pastry.Amount));
        }

        public List<Product> ExtractProducts()
        {
            var storage = Storage.Products;
            return storage;
        }
    }
}