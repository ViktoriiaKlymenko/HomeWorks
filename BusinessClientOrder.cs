﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    /// <summary>
    /// Intended for working with a business client's order.
    /// </summary>
    public class BusinessClientOrder : Consumer
    {
        public static void RegisterPastryFromOrder(string nameAndAmount)
        {
            var amount = nameAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
            var name = nameAndAmount.Trim(amount.ToCharArray());
            name = name.Trim(' ');

            var names = AvailableProducts.Name.ToList();
            var adresses = AvailableProducts.Adress.ToList();
            var phoneNumbers = AvailableProducts.PhoneNumber.ToList();
            var productNames = AvailableProducts.ProductName.ToList();
            var types = AvailableProducts.Type.ToList();
            var weights = AvailableProducts.Weight.ToList();
            var consists = AvailableProducts.Consist.ToList();
            var prices = AvailableProducts.Price.ToList();
            var amounts = AvailableProducts.Amount.ToList();
            var twentyunitsdiscount = AvailableProducts.TwentyUnitsDiscount.ToList();
            var fiftyunitsdiscount = AvailableProducts.FiftyUnitsDiscount.ToList();
            var hundredunitsdiscount = AvailableProducts.HundredUnitsDiscount.ToList();

            for (int i = 0; i < names.Count; i++)
            {
                if (string.Compare(productNames[i], name) == 0)
                {
                    BusinessClientOrdersCollector.AddPastryToOrders(
                                                            names[i], 
                                                            types[i], 
                                                            prices[i], 
                                                            amounts[i], 
                                                            twentyunitsdiscount[i], 
                                                            fiftyunitsdiscount[i], 
                                                            hundredunitsdiscount[i]);

                    if (Convert.ToInt32(amount) == amounts[i])
                    {
                        names.RemoveAt(i);
                        adresses.RemoveAt(i);
                        phoneNumbers.RemoveAt(i);
                        productNames.RemoveAt(i);
                        types.RemoveAt(i);
                        weights.RemoveAt(i);
                        consists.RemoveAt(i);
                        prices.RemoveAt(i);
                        amounts.RemoveAt(i);
                        twentyunitsdiscount.RemoveAt(i);
                        fiftyunitsdiscount.RemoveAt(i);
                        hundredunitsdiscount.RemoveAt(i);
                    }
                    else
                    {
                        amounts[i] -= Convert.ToInt32(amount);
                    }
                    AvailableProducts.Name = names;
                    AvailableProducts.Type = types;
                    AvailableProducts.Weight = weights;
                    AvailableProducts.Consist = consists;
                    AvailableProducts.Price = prices;
                    AvailableProducts.Amount = amounts;
                    AvailableProducts.TwentyUnitsDiscount = twentyunitsdiscount;
                    AvailableProducts.FiftyUnitsDiscount = fiftyunitsdiscount;
                    AvailableProducts.HundredUnitsDiscount = hundredunitsdiscount;
                }
            }
        }

        internal static void RegisterPersonalData(BusinessClientOrder newOrder)
        {
            Console.Write("Your name: ");
            newOrder.Name = Console.ReadLine();
            Console.Write("Your surname: ");
            newOrder.Surname = Console.ReadLine();
            Console.Write("Phone number: ");
            newOrder.PhoneNumber = Console.ReadLine();
            Console.Write("Delivery adress: ");
            newOrder.Adress = Console.ReadLine();
            BusinessClientOrdersCollector.AddPersonalDataToOrders(newOrder);
        }
    }
}
