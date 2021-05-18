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
        private readonly ILogger _logger;
        public СustomerManager(IStorage availableProducts, IStorage userOrders, ILogger logger)
        {
            _availableProducts = availableProducts;
            _userOrders = userOrders;
            _logger = logger;
        }
        public Pastry ChooseProduct(int id, int amount)
        {
            var pastry = _availableProducts.Pastries.FirstOrDefault(pastry => pastry.Id == id);
            if (amount < pastry.Amount)
            {
                _availableProducts.Pastries.FirstOrDefault(pastry => pastry.Id == id).Amount -= amount;
                _logger.LogChanges(StorageType.AvailableProducts, pastry.GetType(), pastry.ToString(), "amount was decreased");
                return pastry;
            }
            if (pastry.Amount == amount)
            {
                _availableProducts.Pastries.Remove(_availableProducts.Pastries.FirstOrDefault(pastry => pastry.Id == id));
                _logger.LogChanges(StorageType.AvailableProducts, pastry.GetType(), pastry.ToString(), "was deleted");
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
            pastry.Price *= pastry.Amount;
            _userOrders.Pastries.Add(pastry);
           _logger.LogChanges(StorageType.UserOrders, pastry.GetType(), pastry.ToString(), "was added");
            
        }

        public void SaveUser(User user)
        {
            _userOrders.Users.Add(user);
            _logger.LogChanges(StorageType.UserOrders, user.GetType(), user.ToString(), "was added");
        }
    }
}
