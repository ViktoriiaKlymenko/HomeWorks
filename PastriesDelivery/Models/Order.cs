using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> b09788c (Code was improved.)

namespace PastriesDelivery
{
    public class Order
    {
        private Guid Id { get; }
        public Pastry Pastry { get; set; }
        public User User { get; set; }
        public decimal TotalPrice { get; set; }

        public Order(Pastry pastry, User user, decimal totalPrice)
        {
            Pastry = pastry;
            User = user;
            TotalPrice = totalPrice;
            Id = Guid.NewGuid();
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> b09788c (Code was improved.)
