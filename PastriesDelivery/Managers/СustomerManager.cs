using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    public class СustomerManager
    {
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
            return pastry;
        }

        public bool CheckForDataPrescence()
        {
            if (_availableProducts.Pastries.Count is 0)
            {
                return false;
            }
            return true;
        }

        public virtual void SaveOrder(Pastry pastry)
        {
<<<<<<< HEAD
            pastry.Price *= pastry.Amount;
            _userOrders.Pastries.Add(pastry);
=======
            var totalPrice = pastry.Price * pastry.Amount;
            Storage.Orders.Add(new Order(pastry, user, totalPrice));
>>>>>>> 532ba61 (Mistakes were fixed.)
        }

        public void SaveUser(User user)
        {
            _userOrders.Users.Add(user);
        }
    }
}
