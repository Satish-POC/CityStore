using System;
using System.Collections.Generic;
using System.Text;

namespace CityShop.Domain.Models
{
    public class FxRate
    {
        /// <summary>The source currency for the exchange rate</summary>
        [Newtonsoft.Json.JsonProperty("sourceCurrency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceCurrency { get; set; }

        /// <summary>The target currency for the exchange rate</summary>
        [Newtonsoft.Json.JsonProperty("targetCurrency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TargetCurrency { get; set; }

        /// <summary>The conversation rate from the source currency to the target currency</summary>
        [Newtonsoft.Json.JsonProperty("rate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Rate { get; set; }


    }
}
