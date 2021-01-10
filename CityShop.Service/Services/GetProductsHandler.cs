using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CityShop.Data.IRepositories;
using CityShop.Domain.Dtos;
using CityShop.Domain.Models;
using CityShop.Domain.Queries;
using CityShop.Service.Dxos;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CityShop.Service.Services
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, List<ProductReadDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductDxos _productDxos;
        private readonly ILogger _logger;

        public GetProductsHandler(IProductRepository productRepository, IProductDxos productDxos, ILogger<GetProductsHandler> logger)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _productDxos = productDxos ?? throw new ArgumentNullException(nameof(productDxos));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<List<ProductReadDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllAsync();
            if(products != null)
            {
                _logger.LogInformation($"Request to fetch all products");
                var productDtos = _productDxos.MapPorductReadDtoList(products.ToList());
                return productDtos;
            }
            return null;
        }

    }
}
