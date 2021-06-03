using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    /// <summary>
    /// Intended for work with a provider's offers.
    /// </summary>
    public class ProviderOffer : Provider
    {
        public Pastry Pastry { get; set; }
        public int ProductAmount { get; set; }

        public int FiveUnitsDiscont { get; set; }
        public int TenUnitsDiscount { get; set; }
        public int FiftyUnitsDiscount { get; set; }
    }
}
