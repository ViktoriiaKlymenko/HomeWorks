using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with business client.
    /// </summary>
    public class BusinessClientManager : IOrderMaker
    {
        public bool CheckForDataPrescence()
        {
            if (AvailableProducts.Products.Count is 0)
            {
                return false;
            }
            return true;
        }

        public void ChooseProduct(string idAndAmount)
        {
            try
            {
                var id = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]);
                var amount = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);

                foreach (var product in AvailableProducts.Products.ToList<Pastry>())
                {
                    if (amount > product.Amount && id == product.Id)
                    {
                        Messenger.ShowUnavailableAmountMessage();
                        continue;

                    }
                    if (id == product.Id)
                    {
                        SendOrderToStorage(product);
                        if (amount == product.Amount)
                        {
                            AvailableProducts.Products.RemoveAll(product => product.Id == id);
                        }
                        if (amount < product.Amount)
                        {
                            product.Amount -= amount;

                        }

                    }
                }
            }
            catch(FormatException)
            {
                Messenger.ShowWrongDataMessage();
            }
        }

        public string ConfirmOrder()
        {
            Messenger.ShowConfirmMessage();
            var answer = Console.ReadLine();
            return answer;
        }

        private static void SendOrderToStorage(Pastry product)
        {
            product.Price *= product.Amount;
            ApplyDiscount(product);
            BusinessClientStorage.Products.Add(product);
            Messenger.ShowOrderAcceptedMessage();
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
