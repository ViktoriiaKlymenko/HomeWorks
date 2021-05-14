using System;

namespace PastriesDelivery
{
    public class ProviderUI
    {
        private readonly IStorage _storage;

        public ProviderUI(IStorage storage)
        {
            _storage = storage;
        }

        public Pastry AcceptData(BusinessProviderManager manager, Pastry pastry)
        {
            var validator = new DataValidator();
            Console.WriteLine();
            pastry.Id = manager.SetId()+1;
            pastry.Name = Console.ReadLine();
            pastry.Type = Console.ReadLine();
            string weight;
            string price;
            string amount;
            do
            {
                weight = Console.ReadLine();
            } while (!validator.ValidateIsDigit(weight));
            pastry.Weight = Convert.ToInt32(weight);
            do
            {
                price = Console.ReadLine();
            } while (!validator.ValidateIsDigit(price));
            pastry.Price = Convert.ToDecimal(price);
            do
            {
                amount = Console.ReadLine();
            } while (!validator.ValidateIsDigit(amount));
            pastry.Amount = Convert.ToInt32(amount);
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