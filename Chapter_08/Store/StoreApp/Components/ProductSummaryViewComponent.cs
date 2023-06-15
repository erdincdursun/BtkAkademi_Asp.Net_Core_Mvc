using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using StoreApp.Models;

namespace StoreApp.Components
{

    public class ProductSummaryViewComponent : ViewComponent
    {

        private readonly IServiceManager _manager; // 
        public ProductSummaryViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager.ProductService.GetAllProducts(false).Count().ToString();
        }
    }
}