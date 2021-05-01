using System.Collections.Generic;

namespace PastriesDelivery
{
    /// <summary>
    /// This class keeps orders of business client.
    /// </summary>
    public class BusinessClientStorage
    {
        private List<Pastry> products = new List<Pastry>();

        public List<Pastry> Products
        {
            get { return products; }
            set { }
        }

        public BusinessClient User { get; }
    }
}