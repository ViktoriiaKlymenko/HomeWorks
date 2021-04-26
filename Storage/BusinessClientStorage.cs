using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    /// <summary>
    /// This class keeps orders of business client.
    /// </summary>
    public class BusinessClientStorage
    {
        private static List<Pastry> products = new List<Pastry>();
        public static List<Pastry> Products
        {
            get { return products; }
            set { }
        }
        public static BusinessClient User { get; }

    }
}
