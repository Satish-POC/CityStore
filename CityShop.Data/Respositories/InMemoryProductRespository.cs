using CityShop.Data.IRepositories;
using CityShop.Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CityShop.Data.Repositories
{
    public class InMemoryProductRespository : IProductRepository
    {
        public async Task<IEnumerable<Product>> GetAllAsync()
        {

            var products = new List<Product>
            {
                new Product() { ProductId = "1", Name = "iPhone 12 Pro Max Blue", Description = "Blue iPhone Pro Max", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "2", Name = "iPhone 12 Pro Max Gold", Description = "Gold iPhone Pro Max", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "3", Name = "iPhone 12 Pro Max Silver", Description = "Silver iPhone Pro Max", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "4", Name = "iPhone 12 Pro Max Black", Description = "Black iPhone Pro Max", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "5", Name = "iPhone 12 Pro Blue", Description = "Blue iPhone Pro", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "6", Name = "iPhone 12 Pro Gold", Description = "Gold iPhone Pro", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "7", Name = "iPhone 12 Pro Silver", Description = "Silver iPhone Pro", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "8", Name = "iPhone 12 Pro Black", Description = "Black iPhone Pro", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "9", Name = "iPhone 12 Blue", Description = "Blue iPhone", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "10", Name = "iPhone 12 Gold", Description = "Gold iPhone", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "11", Name = "iPhone 12 Silver", Description = "Silver iPhone", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "12", Name = "iPhone 12 Black", Description = "Black iPhone", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "13", Name = "iPhone 12 Mini Gold", Description = "Gold iPhone Mini", MaximumQuantity = 20, UnitPrice = 2000 },
                new Product() { ProductId = "14", Name = "iPhone 12 Mini Silver", Description = "Silver iPhone Mini", MaximumQuantity = 20, UnitPrice = 2000 }
            };


            return await Task.FromResult(products);

        }
    }
}
