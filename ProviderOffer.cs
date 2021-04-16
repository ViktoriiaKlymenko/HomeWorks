using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    class ProviderOffer : Provider // this class describes an offer of provider's product
    {
        private Guid ProductId { get; set; }
        public int ProductAmount { get; set; }

        public int FiveUnitsDiscont { get; set; }
        public int TenUnitsDiscount { get; set; }
        public int FiftyUnitsDiscount { get; set; }
    }

}
