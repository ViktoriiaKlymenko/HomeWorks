using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace PastriesDelivery
{
    public class CurrencyService : ICurrencyService
    {
        private static readonly Uri Uri = new Uri("https://api.privatbank.ua/p24api/pubinfo?exchange&json&coursid=11");

        public async Task<List<CurrencyDetails>> DownloadCurrenciesRateAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var jsonString = await httpClient.GetStringAsync(Uri);
                var jArray = JArray.Parse(jsonString);
                return jArray.ToObject<List<CurrencyDetails>>();
            }
        }
    }
}
