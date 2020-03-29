using MyClassLibaray.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.Repository
{
    public class ProductRepository:IProductRepository
    {
        public async Task<List<Product>> GetAllProducts()
        {
            return await Product();
        }
        private async Task<List<Product>> Product()
        {
            return new List<Product>()
            {
                new Product {ProductName="AA", ProductDesc="AA"},
                new Product {ProductName="BB", ProductDesc="BB"},
            };
        }
    }
}
