using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    abstract public class Pastry // contains a description of pastries that provider will offer
    {
        private Guid PastryId { get; set; }
        public string PastryName { get; set; }
        public string PastryType { get; set; }
        public double PastryWeight { get; set; }
        public string[] PastryConsist { get; set; }
        public decimal PastryPrice { get; set; }
        public string[] PastryFeedbacks { get; set; }
    }

}
