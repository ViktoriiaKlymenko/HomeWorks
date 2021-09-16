using Newtonsoft.Json;
using System.Text.Json;

namespace PastriesDelivery
{
    public class Currency
    {
        [JsonProperty("ccy")]
        public string CurrencyName { get; set; }

        [JsonProperty("base_ccy")]
        public string BaseCurrency { get; set; }

        [JsonProperty("buy")]
        public decimal Buy { get; set; }

        [JsonProperty("sale")]
        public decimal Sale { get; set; }
    }
}