using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains provider's main information.
    /// </summary>
    public class Provider
    {
        static public int Id { get; set; } = 1;
        static public string Name { get; set; } = "Absolute company name";
        static public string Adress { get; set; } = "Absolute adress";
        static public string PhoneNumber { get; set; } = "+380XXXXXXXXX";
        static public int twentyUnitsDiscount { get; set; } = 2;
        static public int fiftyUnitsDiscount { get; set; } = 3;
        static public int hundredUnitsDiscount { get; set; } = 4;
    }
}
