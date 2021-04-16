using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDeliveryTypeSystem
{
    class ProviderOffer : Provider // this class describes an offer of provider's product
    {
        public Pastry Pastry { get; set; }
        public int ProductAmount { get; set; }

        public int FiveUnitsDiscont { get; set; }
        public int TenUnitsDiscount { get; set; }
        public int FiftyUnitsDiscount { get; set; }


        public ProviderOffer(int productAmount, int fiveUnitsDiscont, int tenUnitsDiscount, int fiftyUnitsDiscount, Pastry pastry)
        {           
            this.ProductAmount = productAmount;
            this.FiveUnitsDiscont = fiveUnitsDiscont;
            this.TenUnitsDiscount = tenUnitsDiscount;
            this.FiftyUnitsDiscount = fiftyUnitsDiscount;
            this.Pastry = pastry;
        }
    }
}
