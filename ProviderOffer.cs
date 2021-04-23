using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    /// <summary>
    /// Intended for work with a provider's offers.
    /// </summary>
    public class ProviderOffer : Provider
    {
        public int ProductAmount { get; set; }
        public int TwentyUnitsDiscont { get; set; }
        public int FiftyUnitsDiscount { get; set; }
        public int HundredUnitsDiscount { get; set; }

        public static void GetOrderData()
        {
            Console.Write("Company name: ");
            var name = Console.ReadLine();
            Console.Write("Phone number: ");
            var phoneNumber = Console.ReadLine();
            Console.Write("Adress: ");
            var adress = Console.ReadLine();
            Console.Write("Pastrie name: ");
            var productName = Console.ReadLine();
            Console.Write("Pastrie type: ");
            var type = Console.ReadLine();
            Console.Write("Pastrie weight in gm: ");
            var weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pastrie consist: ");
            var consist = Console.ReadLine();
            Console.Write("Pastrie price USD: ");
            var price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Available amount: ");
            var amount = Convert.ToInt32(Console.ReadLine());

            Console.Write("20 units discount: ");
            var twentyUnitsDiscount = Convert.ToInt32(Console.ReadLine());
            Console.Write("50 units discount: ");
            var fiftyUnitsDiscount = Convert.ToInt32(Console.ReadLine());
            Console.Write("100 units discount: ");
            var hundredUnitsDiscount = Convert.ToInt32(Console.ReadLine());
            ProviderOffer.AddToAvailableProducts(
                            name,
                            phoneNumber,
                            adress,
                            productName,
                            type,
                            weight,
                            consist,
                            price,
                            amount,
                            twentyUnitsDiscount,
                            fiftyUnitsDiscount,
                            hundredUnitsDiscount);
        }

        private static void AddToAvailableProducts(
                                        string name, 
                                        string phoneNumber, 
                                        string adress, 
                                        string productName, 
                                        string type, 
                                        int weight, 
                                        string consist, 
                                        decimal price, 
                                        int amount, 
                                        int twentyUnitsDiscount, 
                                        int fiftyUnitsDiscount, 
                                        int hundredUnitsDiscount)
        {
            var names =new List<string>();
            var adresses = new List<string>();
            var phoneNumbers = new List<string>();
            var productNames = new List<string>();
            var types = new List<string>();
            var weights = new List<int>();
            var consists = new List<string>();
            var prices = new List<decimal>();
            var amounts = new List<int>();
            var twentyUnitsDiscounts = new List<int>();
            var fiftyUnitsDiscounts = new List<int>();
            var hundredUnitsDiscounts = new List<int>();
            var answer = CheckAndConfirm();
            if (answer is "yes")
            {
                try
                {
                    names = AvailableProducts.Name.ToList();
                    phoneNumbers = AvailableProducts.PhoneNumber.ToList();
                    adresses = AvailableProducts.Adress.ToList();
                    productNames = AvailableProducts.ProductName.ToList();
                    types = AvailableProducts.Type.ToList();
                    weights = AvailableProducts.Weight.ToList();
                    consists = AvailableProducts.Consist.ToList();
                    prices = AvailableProducts.Price.ToList();
                    amounts = AvailableProducts.Amount.ToList();
                    twentyUnitsDiscounts = AvailableProducts.TwentyUnitsDiscount.ToList();
                    fiftyUnitsDiscounts = AvailableProducts.FiftyUnitsDiscount.ToList();
                    hundredUnitsDiscounts = AvailableProducts.HundredUnitsDiscount.ToList();
                }
                catch (ArgumentNullException)
                {
                }
                names.Add(name);
                phoneNumbers.Add(phoneNumber);
                adresses.Add(adress);
                productNames.Add(productName);
                types.Add(type);
                weights.Add(weight);
                consists.Add(consist);
                prices.Add(price);
                amounts.Add(amount);
                twentyUnitsDiscounts.Add(twentyUnitsDiscount);
                fiftyUnitsDiscounts.Add(fiftyUnitsDiscount);
                hundredUnitsDiscounts.Add(hundredUnitsDiscount);
                AvailableProducts.Name = names;
                AvailableProducts.PhoneNumber = phoneNumbers;
                AvailableProducts.Adress = adresses;
                AvailableProducts.ProductName = productNames;
                AvailableProducts.Type = types;
                AvailableProducts.Weight = weights;
                AvailableProducts.Consist = consists;
                AvailableProducts.Price = prices;
                AvailableProducts.Amount = amounts;
                AvailableProducts.TwentyUnitsDiscount = twentyUnitsDiscounts;
                AvailableProducts.FiftyUnitsDiscount = fiftyUnitsDiscounts;
                AvailableProducts.HundredUnitsDiscount = hundredUnitsDiscounts;
                Console.WriteLine("Your offer was added!");
            }
        }

        private static string CheckAndConfirm()
        {
            Console.WriteLine("Confirm your offer (yes): ");
            var answer = Console.ReadLine();
            return answer;
        }
    }
}