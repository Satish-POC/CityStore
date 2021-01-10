using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CityShop.WebAPI.Service;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using MediatR;
using CityShop.Domain.Queries;
using CityShop.Domain.Dtos;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Logging;

namespace CityShop.WebAPI.Controllers
{
    /// <summary>
    /// This method exposes the endpoint to fetch products.
    /// </summary>
    /// All controllers inherit from ApiControllerBase and mediator is injected in constructor.
    /// ApiControllerBase class uses mediator pattern with a request (either read query ot write command)
    /// and corresponding handler.
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ApiControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IMediator mediator, ILogger<ProductsController> logger) : base(mediator)
        {
            this._logger = logger;
        }
        [EnableCors("PublicWebAppOrigins")]
        [HttpGet]
        public async Task<ActionResult<List<ProductReadDto>>> GetAllProducts()
        {
            try
            {
                var query = new GetProductsQuery();
                var result = await QueryAsync(query);
                return Ok(result);
            }
            catch(Exception ex)
            {
                _logger.LogDebug("API didn't return any product with this message -" + ex.Message);
                return NoContent();
            }
        }
    }
}
