using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityShop.Domain.Dtos
{
    public class ProductReadDto
    {
        [JsonProperty("id")]
        public string  Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("desc")]
        public string Description { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("basePrice")]
        public double BasePrice { get; set; }
    }
}
