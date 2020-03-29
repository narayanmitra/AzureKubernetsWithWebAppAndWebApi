using MyClassLibaray.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebApiService.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();
    }
}
