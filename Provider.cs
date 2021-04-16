using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    abstract public class Provider:Pastry // this class describes main data that must be known about a provider who posts it's product
    {
        public string ProviderName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }

    }
}
