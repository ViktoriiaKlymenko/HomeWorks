using System.Collections.Generic;

namespace PastriesDelivery
{
    /// <summary>
    /// This class keeps list of available products in delivery service.
    /// </summary>
    public class AvailableProducts
    {
        private List<Pastry> products = new List<Pastry>();

        public List<Pastry> Products
        {
            get { return products; }
            set { }
        }

        public Provider Provider { get; }
    }
}