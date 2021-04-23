using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    /// <summary>
    /// Intended for working with a consumer.
    /// </summary>
    public class Consumer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public static void GreetUser()
        {
            Console.WriteLine("\nWe are glad to see you in our pastries delivery! Are you provider, end-user or business client?");
        }

        public static void ShowOrderRequirments()
        {
            Console.WriteLine("Enter an amount and the name of the pastry.");
        }

        internal static string ConfirmOrder()
        {
            Console.Write("Confirm your order (yes): ");
            var answer = Console.ReadLine();
            return answer;
        }
    }
}
