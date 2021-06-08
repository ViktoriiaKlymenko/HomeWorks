using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    public interface ICurrencyConverter
    {
        decimal ConvertToUSD(decimal totalPrice, IList<Currency> currenciesRate);

    }
}
