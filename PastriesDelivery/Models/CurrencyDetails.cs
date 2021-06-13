using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace PastriesDelivery
{
    public class CurrencyDetails
    {
        [JsonProperty("ccy")]
        public string Currency { get; set; }

        [JsonProperty("base_ccy")]
        public string BaseCurrency { get; set; }

        [JsonProperty("buy")]
        public decimal Buy { get; set; }

        [JsonProperty("sale")]
        public decimal Sale { get; set; }
    }
}
