using System;
using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with end-user.
    /// </summary>
    public class EndUserManager : IOrderMaker
    {
        private readonly AvailableProducts _availableProduct;
        public EndUserManager(AvailableProducts availableProducts)
        {
            _availableProduct = availableProducts;
        }
        public bool CheckForDataPrescence()
        {
            if (_availableProduct.Products.Count is 0)
            {
                return false;
            }
            return true;
        }

        public Pastry ChooseProduct(string idAndAmount)
        {
            Pastry pastry = new Pastry();
            var id = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]);
            var amount = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);

            foreach (var product in _availableProduct.Products.ToList<Pastry>())
            {
                if (amount > product.Amount && id == product.Id)
                {
                    Messenger.ShowUnavailableAmountMessage();
                    continue;
                }
                if (id == product.Id)
                {
                    pastry = product;
                    if (amount == product.Amount)
                    {
                        _availableProduct.Products.RemoveAll(product => product.Id == id);
                    }
                    if (amount < product.Amount)
                    {
                        product.Amount -= amount;
                    }
                }
            }
            return pastry;
        }

        public string ConfirmOrder()
        {
            Messenger.ShowConfirmMessage();
            var answer = Console.ReadLine();
            return answer;
        }

        public EndUserStorage SendOrderToStorage(EndUserStorage endUserStorage, Pastry pastry)
        {
            endUserStorage.Products.Add(pastry);
            Messenger.ShowOrderAcceptedMessage();
            return endUserStorage;
        }
    }
}