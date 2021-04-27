using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    /// <summary>
    /// This class keeps list of available products in delivery service.
    /// </summary>
    static public class AvailableProducts
    {
        private static List<Pastry> products = new List<Pastry>();
        public static List<Pastry> Products
        {
            get { return products; }
            set { }
        }
        public static Provider Provider { get; }

    }
}
