using System;

namespace PastriesDelivery
{
    public class ProviderUI
    {
<<<<<<< HEAD
        public static Pastry AcceptData(BusinessProviderManager manager, Pastry pastry)
        {
=======
        public Pastry AcceptData(BusinessProviderManager manager, Pastry pastry)
        {
            var validator = new DataValidator();
>>>>>>> 6503217 (Code was improved.)
            Console.WriteLine();
            pastry.Id = manager.SetId() + 1;
            pastry.Name = Console.ReadLine();
            pastry.Type = Console.ReadLine();
<<<<<<< HEAD

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
=======
            do
            {
                pastry.Weight = validator.ValidateIsDigit(Console.ReadLine());
            } while (pastry.Weight == default);
            do
            {
                pastry.Price = validator.ValidateIsDigit(Console.ReadLine());
            } while (pastry.Price == default);
            do
            {
                pastry.Amount = validator.ValidateIsDigit(Console.ReadLine());
            } while (pastry.Amount == default);
            return pastry;
        }
>>>>>>> 6503217 (Code was improved.)

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    pastry.Amount = result;
                }

            } while (pastry.Amount == default);

            return pastry;
        }
    }
}