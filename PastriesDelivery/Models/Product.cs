﻿using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> b09788c (Code was improved.)

namespace PastriesDelivery
{
    public class Product
    {
        private Guid Id { get; }
        public Pastry Pastry { get; set; }
        public User User { get; set; }

        public Product(Pastry pastry, User user)
        {
            Pastry = pastry;
            User = user;
            Id = Guid.NewGuid();
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> b09788c (Code was improved.)
