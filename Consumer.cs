using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    abstract class Consumer // contains main data that must be known about every consumer that will order
    {
        public string ProductName { get; set; }
        public int ProductAmount { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string[] PaymentMethod { get; set; } = { "Cash", "Card", "Mobile payment" };
    }
}
