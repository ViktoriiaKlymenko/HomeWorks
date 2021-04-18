using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    /// <summary>
    /// Intended for working with an end-user's order.
    /// </summary>
    public class EndUserOrder : Consumer 
    {
        private Guid Id { get; set; }
        public Pastry Pastry { get; set; }
    }
}
