using System;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with provider.
    /// </summary>
    public class ProviderManager : IOffersMaker
    {
        public AvailableProducts AddNewOffer(AvailableProducts availableProducts, Pastry product)
        {
            availableProducts.Products.Add(product);
            Messenger.ShowOfferAcceptedMessage();
            return availableProducts;
        }

        public AvailableProducts AcceptData(AvailableProducts availableProducts, Pastry pastry)
        {
            int id = 0;
            Console.WriteLine();
            pastry.Id = SetId(id, availableProducts) + 1;
            pastry.Name = Console.ReadLine();
            pastry.Type = Console.ReadLine();
            pastry.Weight = Convert.ToInt32(Console.ReadLine());
            pastry.Price = Convert.ToDecimal(Console.ReadLine());
            pastry.Amount = Convert.ToInt32(Console.ReadLine());
            return availableProducts;
        }

        private static int SetId(int i, AvailableProducts availableProducts)
        {
            foreach (var product in availableProducts.Products)
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