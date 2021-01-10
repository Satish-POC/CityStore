using System;
using System.Collections.Generic;
using System.Text;
using CityShop.Domain.Dtos;
using MediatR;
using Newtonsoft.Json;

namespace CityShop.Domain.Queries
{
    public class GetProductsQuery : QueryBase<List<ProductReadDto>>
    {
        [JsonConstructor]
        public GetProductsQuery() { }
    }
}
