﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains end-user's main information.
    /// </summary>
    public class EndUser: Consumer
    {
        static public int Id { get; set; } = 1;
        static public string Name { get; set; } = "Client name";
        static public string Adress { get; set; } = "Client adress";
        static public string PhoneNumber { get; set; } = "+380XXXXXXXXX";

    }
}