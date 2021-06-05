using System;

namespace PastriesDelivery
{
    public class ProviderUI
    {
        public static Pastry AcceptData(BusinessProviderManager manager, Pastry pastry)
        {
<<<<<<< HEAD
            pastry.Id = manager.SetId();
=======
            Console.WriteLine();
            pastry.Id = manager.SetId() + 1;
>>>>>>> main
            pastry.Name = Console.ReadLine();
            pastry.Type = Console.ReadLine();

            do
            {
<<<<<<< HEAD
=======

>>>>>>> main
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    pastry.Weight = result;
                }
<<<<<<< HEAD
=======

>>>>>>> main
            } while (pastry.Weight == default);

            do
            {
<<<<<<< HEAD
=======

>>>>>>> main
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    pastry.Price = result;
                }
<<<<<<< HEAD
=======

>>>>>>> main
            } while (pastry.Price == default);

            do
            {
<<<<<<< HEAD
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    pastry.Amount = result;
                }
            } while (pastry.Amount == default);

=======

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    pastry.Amount = result;
                }

            } while (pastry.Amount == default);

>>>>>>> main
            return pastry;
        }
    }
}