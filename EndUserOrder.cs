using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    class EndUserOrder : Consumer // intended for work with end-user
    {
        private Guid OrderId { get; set; }
    }
}
