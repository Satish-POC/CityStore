using CityShop.Data.IRepositories;
using CityShop.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CityShop.Service.Services;
using CityShop.Service.Dxos;
using Castle.Core.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using CityShop.Domain.Queries;
using System.Threading;

namespace CityShop.Service.Test
{
    [TestClass]
    public class GetProductsHandlerTests
    {
        /// <summary>
        /// Precondition -
        ///     - Pass a product object with price 100.
        /// Test Case
        ///     - Price should be high by 20%.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task ShouldReturnPricesIncreasedBy20Percent()
        {

            //
            var products = new List<Product>
            {
                new Product{ProductId = "1", Description="Desc1", Name="p1", UnitPrice = 100.0}
            };

            Mock<IProductRepository> productRepoMock = new Mock<IProductRepository>();
            productRepoMock.Setup(repo => repo.GetAllAsync())
                .ReturnsAsync(products);

            ProductDxos productDxos = new ProductDxos();

            var handlr = new GetProductsHandler(productRepoMock.Object, productDxos, new NullLogger<GetProductsHandler>()) ;

            GetProductsQuery queryObj = new GetProductsQuery();

            var productDtos = await handlr.Handle(queryObj, CancellationToken.None);

            Assert.AreEqual(120.0, productDtos[0].Price);
        }
    }
}
