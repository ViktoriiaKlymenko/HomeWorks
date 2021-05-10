using System;
using System.Collections.Generic;
using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for showing messages.
    /// </summary>
    public class Messenger
    {
        private readonly IList<Pastry> _availableProducts;

        public Messenger(IStorage storage)
        {
            _availableProducts = new List<Pastry>();
            for (int i = 0; i < storage.Pastries.Count; i++)
            {
                if (storage.Type[i] == StorageType.AvailableProducts)
                {
                    _availableProducts.Add(storage.Pastries[i]);
                }
            }
        }

        public static void GreetUser()
        {
            Console.WriteLine("Hello. Please, indicate who are you: provider, consumer or business client.");
        }

        public static void SendOfferRequirments()
        {
            Console.WriteLine("Enter please product data in the next format:\nName\nType\nWeight (in gr)\nPrice (in USD)\nAmount");
        }

        public static void SendOrderRequirments()
        {
            Console.Write("Enter please id of product and it's amount: ");
        }

        public static void ShowAvailableProductsMessage()
        {
            Console.WriteLine("Available products:");
        }

        internal static void ShowOfferAcceptedMessage()
        {
            Console.WriteLine("Your offer was accepted!");
        }

        internal static void ShowWrongDataMessage()
        {
            Console.WriteLine("Wrong format or string can't be empty! Please, try again.");
        }

        internal static void ShowConfirmMessage()
        {
            Console.WriteLine("Please confirm (yes/no): ");
        }

        internal void ShowUnavailableAmountMessage(string idAndAmount)
        {
            var id = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0]);
            var amount = Convert.ToInt32(idAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
            foreach (var product in _availableProducts.ToList<Pastry>())
            {
                if (amount > product.Amount && id == product.Id)
                {
                    Console.WriteLine("Unavailable amount of product! Try again!");
                    continue;
                }
            }
        }

        internal static void ShowOrderAcceptedMessage()
        {
            Console.WriteLine("Your order was accepted! Thank you!");
        }

        internal static void ShowNoProductsMessage()
        {
            Console.WriteLine("There is no available products to buy!");
        }

        internal static void ShowEnterAddressMessage()
        {
            Console.Write("Please, enter your adress.");
        }

        internal static void ShowEnterPhoneNumberMessage()
        {
            Console.Write("Please, enter your phone number.");
        }
    }
}