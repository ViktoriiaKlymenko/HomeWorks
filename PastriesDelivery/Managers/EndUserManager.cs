using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with end-user.
    /// </summary>
    public class EndUserManager : IOrderMaker
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
            EndUserStorage.Products.Add(product);
            Messenger.ShowOrderAcceptedMessage();
        }
    }
}
