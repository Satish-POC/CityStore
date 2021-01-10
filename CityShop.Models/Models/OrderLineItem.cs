using System;
using System.Collections.Generic;
using System.Text;

namespace CityShop.Domain.Models
{
    public class OrderLineItem
    {
        /// <summary>The id for the product to order</summary>
        [Newtonsoft.Json.JsonProperty("productId", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ProductId { get; set; }

        /// <summary>The quantity of the product to order</summary>
        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1, 2147483647)]
        public int? Quantity { get; set; }


    }
}
