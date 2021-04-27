using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for work with consumer interface.
    /// </summary>
    class ConsumerUI
    {
        public static string GetOrder()
        {
            return Console.ReadLine();
        }
    }
}
