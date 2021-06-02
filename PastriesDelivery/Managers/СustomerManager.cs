using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    public class СustomerManager
    {
<<<<<<< HEAD
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

=======
        private readonly IStorage _availableProducts;
        private readonly IStorage _userOrders;

        public СustomerManager(IStorage availableProducts, IStorage userOrders)
        {
            _availableProducts = availableProducts;
            _userOrders = userOrders;
        }
        public Pastry ChooseProduct(int id, int amount)
        {
            var pastry = _availableProducts.Pastries.FirstOrDefault(pastry => pastry.Id == id);
            if (amount < pastry.Amount)
            {
                _availableProducts.Pastries.FirstOrDefault(pastry => pastry.Id == id).Amount -= amount;
                return pastry;
            }
            if (pastry.Amount == amount)
            {
                _availableProducts.Pastries.Remove(_availableProducts.Pastries.FirstOrDefault(pastry => pastry.Id == id));
                return pastry;
            }

            if (amount > pastry.Amount || amount <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
>>>>>>> 6503217 (Code was improved.)
            return pastry;
        }

        public bool CheckForDataPrescence()
        {
<<<<<<< HEAD
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
=======
            if (_availableProducts.Pastries.Count is 0)
            {
                return false;
            }
            return true;
        }

        public virtual void SaveOrder(Pastry pastry)
        {
            pastry.Price *= pastry.Amount;
            _userOrders.Pastries.Add(pastry);
        }

        public void SaveUser(User user)
        {
            _userOrders.Users.Add(user);
>>>>>>> 6503217 (Code was improved.)
        }
    }
}
