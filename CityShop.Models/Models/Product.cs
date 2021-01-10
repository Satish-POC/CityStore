using System;
using System.Collections.Generic;
using System.Text;

namespace CityShop.Domain.Models
{
    public class Product
    {
        /// <summary>The unique identifier for the product</summary>
        [Newtonsoft.Json.JsonProperty("productId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>The name of the product</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>A description for the product</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>The unit price for the product in Australian Dollars (AUD)</summary>
        [Newtonsoft.Json.JsonProperty("unitPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnitPrice { get; set; }

        /// <summary>The maximum quantity that is allowed to be ordered (in a single order) for the product</summary>
        [Newtonsoft.Json.JsonProperty("maximumQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MaximumQuantity { get; set; }


    }
}
