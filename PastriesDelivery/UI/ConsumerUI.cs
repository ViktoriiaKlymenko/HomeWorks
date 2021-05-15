using System;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for work with consumer interface.
    /// </summary>
    internal class ConsumerUI : IDataDisplayer
    {
        private readonly IStorage _availableProducts;

        public ConsumerUI(IStorage availableProducts)
        {
            _availableProducts = availableProducts;
        }

        public void DisplayAvailableProducts()
        {
            foreach (var pastry in _availableProducts.Pastries)
            {
                Console.WriteLine("Pastry Id: " + pastry.Id);
                Console.WriteLine("Pastry name: " + pastry.Name);
                Console.WriteLine("Pastry type: " + pastry.Type);
                Console.WriteLine("Pastry weight: " + pastry.Weight + " gr");
                Console.WriteLine("Pastry price: " + pastry.Price + " USD");
                Console.WriteLine("Pastry amount: " + pastry.Amount);
            }
        }

        public static string GetAddress()
        {
            string address;
            address = Console.ReadLine();
            return address;
        }

        public static string GetPhoneNumber()
        {
            string phoneNumber;
            phoneNumber = Console.ReadLine();
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