using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    /// <summary>
    /// Intended for working with an end-user's order.
    /// </summary>

    public class EndUserOrder : Consumer, IEndUserOrder
    {
        public void RegisterPastryFromOrder(string nameAndAmount)
        {
            var amountOrder = nameAndAmount.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
            var nameOrder = nameAndAmount.Trim(amountOrder.ToCharArray());
            nameOrder = nameOrder.Trim(' ');

            var names = AvailableProducts.Name.ToList();
            var adresses = AvailableProducts.Adress.ToList();
            var phoneNumbers = AvailableProducts.PhoneNumber.ToList();
            var productNames = AvailableProducts.ProductName.ToList();
            var types = AvailableProducts.Type.ToList();
            var weights = AvailableProducts.Weight.ToList();
            var consists = AvailableProducts.Consist.ToList();
            var prices = AvailableProducts.Price.ToList();
            var amounts = AvailableProducts.Amount.ToList();

            for (int i = 0; i < names.Count; i++)
            {
                if (string.Compare(productNames[i], nameOrder) == 0)
                {
                    EndUserOrdersCollector.AddPastryToOrders(names[i], types[i], prices[i], amounts[i]);

                    if (Convert.ToInt32(amountOrder) == amounts[i])
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
                    }
                    else
                    {
                        amounts[i] -= Convert.ToInt32(amountOrder);
                    }
                    AvailableProducts.Name = names;
                    AvailableProducts.Type = types;
                    AvailableProducts.Weight = weights;
                    AvailableProducts.Consist = consists;
                    AvailableProducts.Price = prices;
                    AvailableProducts.Amount = amounts;
                }
            }
        }

        public static void RegisterPersonalData(EndUserOrder newOrder)
        {
            Console.Write("Your name: ");
            newOrder.Name = Console.ReadLine();
            Console.Write("Your surname: ");
            newOrder.Surname = Console.ReadLine();
            Console.Write("Phone number: ");
            newOrder.PhoneNumber = Console.ReadLine();
            Console.Write("Delivery adress: ");
            newOrder.Adress = Console.ReadLine();
            EndUserOrdersCollector.AddPersonalDataToOrders(newOrder);
        }
    }
}