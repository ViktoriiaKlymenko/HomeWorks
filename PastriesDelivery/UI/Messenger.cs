using System;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for showing messages.
    /// </summary>
    public class Messenger
    {
        private readonly IStorage _storage;

        public Messenger(IStorage storage)
        {
            _storage = storage;
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

        internal void ShowUnavailableAmountMessage(int id, int amount)
        {
            for (int i = 0; i < _storage.Pastries.Count; i++)
            {
                var pastry = _storage.Pastries[i];
                if (amount > pastry.Amount && id == pastry.Id)
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