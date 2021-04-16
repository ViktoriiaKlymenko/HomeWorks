using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodDeliveryTask
{
    internal class HomeWork
    {
        private static IEnumerable<decimal> NormalizeCurrencies(IEnumerable<decimal> prices, IEnumerable<string> currencies)
        {
            var currenciesList = currencies.ToList();
            var discountedPricesList = prices.ToList();

            for (int i = 0; i < currenciesList.Count(); i++)
            {
                if (currenciesList[i] is not "USD")
                {
                    discountedPricesList[i] = discountedPricesList[i] * Convert.ToDecimal(1.19);
                    currenciesList[i] = "USD";
                }
            }
            return discountedPricesList;
        }

        private static IEnumerable<string> GetStreetName(IEnumerable<string> destinations)
        {
            var streetNames = new List<string>();
            var destinationList = destinations.ToList();

            foreach (var destination in destinationList)
            {
                var streetNameCut = destination.Split(new Char[] { ',' })[0];
                var stringToDelete = streetNameCut.Substring(0, streetNameCut.IndexOf(" ") + 1);
                char[] charsToDelete = stringToDelete.ToCharArray();
                streetNameCut = streetNameCut.Trim(charsToDelete);
                streetNames.Add(streetNameCut);
            }
            return streetNames;
        }

        private static IEnumerable<decimal> ApplyStreetNameDiscount(IEnumerable<string> streetNames, IEnumerable<decimal> prices)
        {
            int i = 0;
            var discountedPrices = prices.ToList();
            var ienumStreetNames = streetNames.GetEnumerator();

            while (ienumStreetNames.MoveNext())
            {
                if (ienumStreetNames.Current is "Wayne Street")
                {
                    discountedPrices[i] += Convert.ToDecimal(10);
                }

                if (ienumStreetNames.Current is "North Heather Street")
                {
                    discountedPrices[i] -= Convert.ToDecimal(5.36);
                }
                i++;
            }
            return discountedPrices;
        }

        private static IEnumerable<decimal> ApplySameStreetDiscount(IEnumerable<string> streetNames, IEnumerable<decimal> prices)
        {
            var discountedPricesList = prices.ToList();
            var streetNamesList = streetNames.ToList();

            for (int i = 0; i < streetNames.Count() - 1; i++)
            {
                if (streetNamesList[i] == streetNamesList[i + 1])
                {
                    discountedPricesList[i + 1] -= discountedPricesList[i + 1] / 100 * 15;
                }
            }
            return discountedPricesList;
        }

        private static IEnumerable<decimal> ApplyDiscountForKids(
                                                     IEnumerable<int> infantsIds,
                                                     IEnumerable<int> childrenIds,
                                                     IEnumerable<decimal> prices)
        {
            var infantsIdsList = infantsIds.ToList();
            var childrenIdsList = childrenIds.ToList();
            var discountedPrices = prices.ToList();

            foreach (var id in infantsIdsList)
            {
                discountedPrices[id] -= discountedPrices[id] / 100 * 50;
            }
            foreach (var id in childrenIdsList)
            {
                discountedPrices[id] -= discountedPrices[id] / 100 * 25;
            }
            return discountedPrices;
        }

        private static bool ValidateDataAmount(int destinations, int clients, int currencies, int prices)
        {
            if (destinations == clients && clients == currencies && currencies == prices)
            {
                return true;
            }
            return false;
        }

        private static decimal GetFullPrice(
                                    IEnumerable<string> destinations,
                                    IEnumerable<string> clients,
                                    IEnumerable<int> infantsIds,
                                    IEnumerable<int> childrenIds,
                                    IEnumerable<decimal> prices,
                                    IEnumerable<string> currencies)
        {
            decimal fullPrice = default;
            var streetNames = GetStreetName(destinations).ToList();
            var discountedPrice = prices.ToList();
            var clientsList = clients.ToList();
            var currenciesList = currencies.ToList();
            var destinationList = destinations.ToList();

            if (!ValidateDataAmount(destinationList.Count, clientsList.Count, currenciesList.Count, discountedPrice.Count))
            {
                return 0;
            }

            NormalizeCurrencies(prices, currencies);
            discountedPrice = ApplyStreetNameDiscount(streetNames, discountedPrice).ToList();
            discountedPrice = ApplyDiscountForKids(infantsIds, childrenIds, discountedPrice).ToList();
            discountedPrice = ApplySameStreetDiscount(streetNames, discountedPrice).ToList();

            for (int i = 0; i < discountedPrice.Count(); i++)
            {
                fullPrice += discountedPrice[i];
            }
            return fullPrice;
        }

        public static decimal InvokePriceCalculatiion()
        {
            var destinations = new[]
            {
                "949 Fairfield Court, Madison Heights, MI 48071",
                "367 Wayne Street, Hendersonville, NC 28792",
                "910 North Heather Street, Cocoa, FL 32927",
                "911 North Heather Street, Cocoa, FL 32927",
                "706 Tarkiln Hill Ave, Middleburg, FL 32068",
            };

            var clients = new[]
            {
                "Autumn Baldwin",
                "Jorge Hoffman",
                "Amiah Simmons",
                "Sariah Bennett",
                "Xavier Bowers",
            };

            var infantsIds = new[] { 2 };
            var childrenIds = new[] { 3, 4 };

            var prices = new[] { 100, 25.23m, 58, 23.12m, 125 };
            var currencies = new[] { "USD", "USD", "EUR", "USD", "USD" };

            return GetFullPrice(destinations, clients, infantsIds, childrenIds, prices, currencies);
        }
    }
}