using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    interface IOrderMaker
    {
        void ChooseProduct(string idAndAmount);
        public string ConfirmOrder();
    }
}
