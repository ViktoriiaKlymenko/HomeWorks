using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdModule
{
    public enum OrderStatus
    {
        ProcessingStock,
        ReadyForPacking,
        ReadyToDeliver,
        DeliveryInProgress,
        Delivered,
        Received,
        Returned
    }
}
