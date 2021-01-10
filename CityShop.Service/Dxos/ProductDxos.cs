using AutoMapper;
using CityShop.Domain.Dtos;
using CityShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityShop.Service.Dxos
{
    public class ProductDxos : IProductDxos
    {
        private readonly IMapper _mapper;

        public ProductDxos()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductReadDto>()
                .ForMember(dst => dst.BasePrice, opt => opt.MapFrom(src => src.UnitPrice))
                .ForMember(dst => dst.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                // Though mapping should not hold the business logic. It's kept here temporarily and will be moved to a separate section.
                .ForMember(dst => dst.Price, opt => opt.MapFrom(src => src.UnitPrice * 1.2));
            });

            _mapper = config.CreateMapper();
        }

        public List<ProductReadDto> MapPorductReadDtoList(List<Product> product)
        {
            return _mapper.Map<List<Product>, List<ProductReadDto>>(product);
        }
    }
}
