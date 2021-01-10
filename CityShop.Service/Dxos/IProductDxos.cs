using CityShop.Domain.Dtos;
using CityShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityShop.Service.Dxos
{
    public interface IProductDxos
    {
        List<ProductReadDto> MapPorductReadDtoList(List<Product> product);
    }
}
