using EntityFrameworkTask;
using System;

namespace PastriesDelivery
{
    public class ProviderUI
    {
        public static Product AcceptData(Product product)
        {
            product.Name = Console.ReadLine();

            do
            {

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    product.Weight = result;
                }

            } while (product.Weight == default);

            do
            {

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    product.Price = result;
                }

            } while (product.Price == default);

            do
            {

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    product.Amount = result;
                }

            } while (product.Amount == default);

            return product;
        }
    }
}