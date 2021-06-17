using System;

namespace PastriesDelivery
{
    public class ProviderUI
    {
        public static Pastry AcceptData(BusinessProviderService service, Pastry pastry)
        {
            pastry.Id = service.SetId();
            pastry.Name = Console.ReadLine();
            pastry.Type = Console.ReadLine();

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