using System;
using System.Collections.Generic;
using System.Text;

namespace CityShop.Domain.Models
{
    public class Order
    {
        /// <summary>The name of the customer</summary>
        [Newtonsoft.Json.JsonProperty("customerName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string CustomerName { get; set; }

        /// <summary>The email address of the customer</summary>
        [Newtonsoft.Json.JsonProperty("customerEmail", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string CustomerEmail { get; set; }

        /// <summary>A list of items to order</summary>
        [Newtonsoft.Json.JsonProperty("lineItems", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<OrderLineItem> LineItems { get; set; } = new System.Collections.ObjectModel.Collection<OrderLineItem>();


    }
}
