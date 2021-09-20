using EntityFrameworkTask;
using System;

namespace PastriesDelivery
{
    public class ProviderUI
    {
        public static Product AcceptData(Product product)
        {
<<<<<<< HEAD
            pastry.Id = manager.SetId();
            pastry.Name = Console.ReadLine();
            pastry.Type = Console.ReadLine();
=======
            product.Name = Console.ReadLine();
>>>>>>> Task4-APILayer

            do
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    product.Weight = result;
                }
<<<<<<< HEAD
            } while (pastry.Weight == default);
=======

            } while (product.Weight == default);
>>>>>>> Task4-APILayer

            do
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    product.Price = result;
                }
<<<<<<< HEAD
            } while (pastry.Price == default);
=======

            } while (product.Price == default);
>>>>>>> Task4-APILayer

            do
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    product.Amount = result;
                }
<<<<<<< HEAD
            } while (pastry.Amount == default);
=======

            } while (product.Amount == default);
>>>>>>> Task4-APILayer

            return product;
        }
    }
}