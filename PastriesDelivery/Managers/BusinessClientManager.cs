using System;
using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with business client.
    /// </summary>
    public class BusinessClientManager : IOrderMaker
    {
        private readonly AvailableProducts _availableProducts;
        public BusinessClientManager(AvailableProducts availableProducts)
        {
            _availableProducts = availableProducts;
        }
        public bool CheckForDataPrescence()
        {
            if (_availableProducts.Products.Count is 0)
            {
                return false;
            }
            return true;
        }

        public Pastry ChooseProduct(string idAndAmount)
        {
            var pastry = new Pastry();
            var id = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]);
            var amount = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);

            foreach (var product in _availableProducts.Products.ToList<Pastry>())
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
                        _availableProducts.Products.RemoveAll(product => product.Id == id);
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

        public BusinessClientStorage SendOrderToStorage(BusinessClientStorage businessClientStudent, Pastry product)
        {
            product.Price *= product.Amount;
            ApplyDiscount(product);
            businessClientStudent.Products.Add(product);
            Messenger.ShowOrderAcceptedMessage();
            return businessClientStudent;
        }

        private static Pastry ApplyDiscount(Pastry product)
        {
            if (product.Amount > 19 && product.Amount < 50)
            {
                product.Price -= product.Price / 100 * Provider.twentyUnitsDiscount;
            }
            if (product.Amount > 49 && product.Amount < 100)
            {
                product.Price -= product.Price / 100 * Provider.fiftyUnitsDiscount;
            }
            if (product.Amount > 99)
            {
                product.Price -= product.Price / 100 * Provider.hundredUnitsDiscount;
            }
            return product;
        }
    }
}