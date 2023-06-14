using Repositories.Contracts;
using StoreApp.Models;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _contex;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public RepositoryManager(IProductRepository productRepository, RepositoryContext contex, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _contex = contex;
            _categoryRepository = categoryRepository;
        }

        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => _categoryRepository;
        public void Save()
        {
            _contex.SaveChanges();
        }
    }
}