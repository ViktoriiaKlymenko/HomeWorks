using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    /// <summary>
    /// Intended for working with a business client's order.
    /// </summary>
    public class BusinessClientOrder : Consumer
    {
        private Guid Id { get; set; }
        public Pastry Pastry { get; set; }
    }
}
