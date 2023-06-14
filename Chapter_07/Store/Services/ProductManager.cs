using Entities.Models;
using Services.Contracts;

namespace Services
{
    public class ProductManager : IProductService
    {
        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}