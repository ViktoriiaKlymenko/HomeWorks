using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    interface IOffersMaker
    {
        public void AddNewOffer(Pastry product);
       
        public string ConfirmOffer();
        public void AcceptData(Pastry product);
    }
}
