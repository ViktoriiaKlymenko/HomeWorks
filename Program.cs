using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Consumer.GreetUser();
                var consumer = Console.ReadLine();
                if (consumer == "end-user")
                {
                    var newOrder = new EndUserOrder();
                    Console.WriteLine("\nAvailable products:");
                    try
                    {
                        AvailableProducts.OutputAvailableProducts();
                    }

                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Sorry! There is nothing to buy!");
                        continue;
                    }
                    Consumer.ShowOrderRequirments();
                    var nameAndAmount = Console.ReadLine();
                    var answer = Consumer.ConfirmOrder();
                    if (answer is "yes")
                    {
                        newOrder.RegisterPastryFromOrder(nameAndAmount);
                        EndUserOrder.RegisterPersonalData(newOrder);
                        Console.WriteLine("Your order was registered! Thank you!");
                    }
                }

                if (consumer == "business client")
                {
                    var newOrder = new BusinessClientOrder();
                    Console.WriteLine("\nAvailable products:");
                    try
                    {
                        AvailableProducts.OutputAvailableProducts();
                    }

                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Sorry! There is nothing to buy!");
                        continue;
                    }
                    Console.WriteLine("\nThere are different discounts for you. ");
                    Console.WriteLine("Choose 20+, 50+ and 100+ units of product and get it.");
                    Consumer.ShowOrderRequirments();
                    var nameAndAmount = Console.ReadLine();
                    var answer = Consumer.ConfirmOrder();
                    if (answer is "yes")
                    {
                        BusinessClientOrder.RegisterPastryFromOrder(nameAndAmount);
                        BusinessClientOrder.RegisterPersonalData(newOrder);
                        Console.WriteLine("Your order was registered! Thank you!");
                    }
                }

                if (consumer == "provider")
                {
                    ProviderOffer.GetOrderData();
                }
            }
        }
    }
}
