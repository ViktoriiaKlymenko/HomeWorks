using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    public class EndUserOrdersCollector
    {
        public static IEnumerable<string> Name { get; set; }
        public static IEnumerable<string> Surname { get; set; }
        public static IEnumerable<string> Adress { get; set; }
        public static IEnumerable<string> PhoneNumber { get; set; }
        public static IEnumerable<string> ProductName { get; set; }
        public static IEnumerable<string> Type { get; set; }
        public static IEnumerable<int> Amount { get; set; }
        public static IEnumerable<decimal> Price { get; set; }

        internal static void AddPastryToOrders(string name, string type, decimal price, int amount)
        {
            var productName = new List<string>();
            var productType = new List<string>();
            var amountInOrder = new List<int>();
            var fullPrice = new List<decimal>();

            if (ProductName is not null)
            {
                productName = ProductName.ToList();
                productType = Type.ToList();
                amountInOrder = Amount.ToList();
                fullPrice = Price.ToList();
            }
            productName.Add(name);
            productType.Add(type);
            amountInOrder.Add(amount);
            fullPrice.Add(price * amount);
            ProductName = productName;
            Type = productType;
            Amount = amountInOrder;
            Price = fullPrice;
        }

        internal static void AddPersonalDataToOrders(EndUserOrder newOrder)
        {
            var clientName = new List<string>();
            var clientSurname = new List<string>();
            var adress = new List<string>();
            var phoneNumber = new List<string>();

            if (Name is not null)
            {
                clientName = Name.ToList();
                clientSurname = Surname.ToList();
                adress = Adress.ToList();
                phoneNumber = PhoneNumber.ToList();
            }
            clientName.Add(newOrder.Name);
            clientSurname.Add(newOrder.Surname);
            adress.Add(newOrder.Adress);
            phoneNumber.Add(newOrder.PhoneNumber);
            Name = clientName;
            Surname = clientSurname;
            Adress = adress;
            PhoneNumber = phoneNumber;
        }
    }
}
