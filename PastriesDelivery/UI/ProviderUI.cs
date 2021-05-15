using System;

namespace PastriesDelivery
{
    public class ProviderUI
    {
        public Pastry AcceptData(BusinessProviderManager manager, Pastry pastry)
        {
            Console.WriteLine();
            pastry.Id = manager.SetId() + 1;
            pastry.Name = Console.ReadLine();
            pastry.Type = Console.ReadLine();
            do
            {
                pastry.Weight = DataValidator.ValidateIsDigit(Console.ReadLine());
            } while (pastry.Weight == default);
            do
            {
                pastry.Price = DataValidator.ValidateIsDigit(Console.ReadLine());
            } while (pastry.Price == default);
            do
            {
                pastry.Amount = DataValidator.ValidateIsDigit(Console.ReadLine());
            } while (pastry.Amount == default);
            return pastry;
        }

        public string ConfirmOffer()
        {
            Messenger.ShowConfirmMessage();
            var answer = Console.ReadLine();
            return answer;
        }
    }
}