using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    public class AvailableProducts
    {
        public static IEnumerable<string> Name { get; set; }
        public static IEnumerable<string> Adress { get; set; }
        public static IEnumerable<string> PhoneNumber { get; set; }
        public static IEnumerable<string> ProductName { get; set; }
        public static IEnumerable<string> Type { get; set; }
        public static IEnumerable<int> Weight { get; set; }
        public static IEnumerable<string> Consist { get; set; }
        public static IEnumerable<decimal> Price { get; set; }
        public static IEnumerable<int> Amount { get; set; }
        public static IEnumerable<int> TwentyUnitsDiscount { get; set; }
        public static IEnumerable<int> FiftyUnitsDiscount { get; set; }
        public static IEnumerable<int> HundredUnitsDiscount { get; set; }

        public static void OutputAvailableProducts()
        {          
                var names = AvailableProducts.Name.ToList();
                var productNames = AvailableProducts.ProductName.ToList();
                var types = AvailableProducts.Type.ToList();
                var weights = AvailableProducts.Weight.ToList();
                var consists = AvailableProducts.Consist.ToList();
                var prices = AvailableProducts.Price.ToList();
                var amounts = AvailableProducts.Amount.ToList();
                for (int i = 0; i < productNames.Count; i++)
                {
                    Console.WriteLine("Company: " + names[i]);
                    Console.WriteLine("Pastry name: " + productNames[i]);
                    Console.WriteLine("Pastry type: " + types[i]);
                    Console.WriteLine("Pastry weight: " + weights[i] + " gr");
                    Console.WriteLine("Pastry consist: " + consists[i]);
                    Console.WriteLine("Pastry price: " + prices[i] + " USD");
                    Console.WriteLine("Pastry amount: " + amounts[i] + "\n");
                }                 
        }
    }
}