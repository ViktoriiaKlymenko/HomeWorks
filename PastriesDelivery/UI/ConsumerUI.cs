using System;

namespace PastriesDelivery
{
    /// <summary>
    /// This class describes methods intended for work with consumer interface.
    /// </summary>
    internal class ConsumerUI
    {
        public static string GetOrder()
        {
            return Console.ReadLine();
        }
    }
}