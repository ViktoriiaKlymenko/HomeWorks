using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    class BusinessClientOrder : Consumer // intended for work with business
    {
        private Guid OrderId { get; set; }
        public Pastry Pastry { get; set; }
    }
}
