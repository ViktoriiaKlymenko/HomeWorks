using System;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for showing messages.
    /// </summary>
    public class Messenger
    {
        public static void GreetUser()
        {
            Console.WriteLine("Hello. Please, indicate who are you: provider, consumer or business client.");
        }

        public static void SendOfferRequirments()
        {
            Console.WriteLine("Enter please product data in the next format:\nName\nType\nWeight (in gr)\nPrice (in USD)\nAmount");
        }

        public static void ShowAvailableProductsMessage()
        {
            Console.WriteLine("Available products: ");
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

        internal static void ShowUnavailableAmountMessage()
        {
            Console.WriteLine("Unavailable amount of product! Try again!");
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
            Console.Write("Please, enter your adress: ");
        }

        internal static void ShowEnterPhoneNumberMessage()
        {
            Console.Write("Please, enter your phone number: ");
        }

        internal static void ShowEnterNameMessage()
        {
            Console.Write("Please, enter your name and surname: ");
        }

        internal static void ShowExitMessage()
        {
            Console.WriteLine("If you want to stop, please enter STOP.");
        }
    }
}