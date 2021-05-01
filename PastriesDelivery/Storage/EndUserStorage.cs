using System.Collections.Generic;

namespace PastriesDelivery
{
    /// <summary>
    /// This class keeps orders of end-user.
    /// </summary>
    public class EndUserStorage
    {
        private List<Pastry> products = new List<Pastry>();

        public List<Pastry> Products
        {
            get { return products; }
            set { }
        }

        public EndUser User { get; }
    }
}