using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nike_clone_Backend.Models;

namespace Nike_clone_Backend.Repositories.ProductRepository
{
    public class ProductRepository
    {
        public Task<ProductModel> AddProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductModel>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> UpdateProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}