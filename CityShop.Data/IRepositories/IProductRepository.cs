using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CityShop.Domain.Models;
namespace CityShop.Data.IRepositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
