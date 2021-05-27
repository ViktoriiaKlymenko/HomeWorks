using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool CheckForDataPrescence()
        {
            return Storage.Products.Count is not 0;
        }

        public virtual void CreateOrder(Pastry pastry, User user)
        {
            var totalPrice = pastry.Price * pastry.Amount;
            Storage.Orders.Add(new Order(pastry, user, totalPrice));
        }

        public List<Product> ExtractProducts()
        {
            var storage = Storage.Products;
            return storage;
        }
    }
}
