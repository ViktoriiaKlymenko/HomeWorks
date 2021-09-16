using System.Collections.Generic;
using System.Threading.Tasks;

namespace PastriesDelivery
{
    public interface ICurrencyService
    {
        Task<List<Currency>> DownloadCurrenciesRateAsync();
    }
}