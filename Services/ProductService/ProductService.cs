using Nike_clone_Backend.Models;

namespace Nike_clone_Backend.Services;
public class ProductService : IProductService
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

    public Task<IEnumerable<ProductModel>> GetProducts(
        string sort,
        string search,
        int page,
        int limit
    )
    {
        throw new NotImplementedException();
    }

    public Task<ProductModel> UpdateProduct(ProductModel product)
    {
        throw new NotImplementedException();
    }
}