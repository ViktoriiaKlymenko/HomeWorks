using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with provider.
    /// </summary>
    public class ProviderManager : IOffersMaker
    {
        public void AddNewOffer(Pastry product)
        {
            AvailableProducts.Products.Add(product);
            Messenger.ShowOfferAcceptedMessage();

        }

        public void AcceptData(Pastry product)
        {
            int id = 0;
            Console.WriteLine();
            product.Id = SetId(id) + 1;
            product.Name = Console.ReadLine();
            product.Type = Console.ReadLine();
            product.Weight = Convert.ToInt32(Console.ReadLine());
            product.Price = Convert.ToDecimal(Console.ReadLine());
            product.Amount = Convert.ToInt32(Console.ReadLine());
        }

        private static int SetId(int i)
        {
            foreach (var product in AvailableProducts.Products)
            {
                if (i < product.Id)
                {
                    i = product.Id;
                }
            }
            return i;
        }

        public string ConfirmOffer()
        {
            Messenger.ShowConfirmMessage();
            var answer = Console.ReadLine();
            return answer;
        }
    }
}
