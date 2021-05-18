using System;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for work with business client interface.
    /// </summary>
    internal class BusinessClientUI : IDataDisplayer
    {
        private readonly IStorage _availableProducts;

        public BusinessClientUI(IStorage availableProducts)
        {
            _availableProducts = availableProducts;
        }

        public void DisplayAvailableProducts()
        {
            foreach (var pastry in _availableProducts.Pastries)
            {
                Console.WriteLine("Pastry Id: " + pastry.Id);
                Console.WriteLine("Pastry name: " + pastry.Name);
                Console.WriteLine("Pastry weight: " + pastry.Type);
                Console.WriteLine("Pastry weight: " + pastry.Weight + " gr");
                Console.WriteLine("Pastry weight: " + pastry.Price + " USD");
                Console.WriteLine("Pastry weight: " + pastry.Amount);
            }
        }

        public static string GetAddress()
        {
            string address;
            var patterns = new RegexPatterns();
            var dataValidator = new DataValidator(patterns);
            do
            {
                address = Console.ReadLine();
            } while (!dataValidator.ValidateAddress(address));
            return address;
        }

        public static string GetPhoneNumber()
        {
            string phoneNumber;
            var patterns = new RegexPatterns();
            var dataValidator = new DataValidator(patterns);
            do
            {
                phoneNumber = Console.ReadLine();
            } while (dataValidator.ValidatePhoneNumber(phoneNumber));
            return phoneNumber;
        }

        public static string GetOrder()
        {
            return Console.ReadLine();
        }

        public string ConfirmOrder()
        {
            var answer = Console.ReadLine();
            return answer;
        }

        internal static int ExtractId(string idAndAmount)
        {
            var id = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]);
            return id;
        }

        internal static int ExtractAmount(string idAndAmount)
        {
            var amount = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
            return amount;
        }

        internal static string GetUserName()
        {
            return Console.ReadLine();
        }
    }
}