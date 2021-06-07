using System;

namespace PastriesDelivery
{
    public class ProviderUI
    {
        public static Pastry AcceptData(BusinessProviderManager manager, Pastry pastry)
        {
            pastry.Name = Console.ReadLine();
            pastry.Type = Console.ReadLine();
            pastry.Id = manager.SetId() + 1;

            do
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    pastry.Weight = result;
                }

            } while (pastry.Weight == default);

            do
            {

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    pastry.Price = result;
                }

            } while (pastry.Price == default);

            do
            {

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    pastry.Amount = result;
                }
            } while (pastry.Amount == default);

            return pastry;
        }
    }
}