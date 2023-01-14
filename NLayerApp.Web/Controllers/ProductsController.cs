using Microsoft.AspNetCore.Mvc;
using NLayerApp.Core.Services;

namespace NLayerApp.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _services;

        public ProductsController(IProductService productService)
        {
            _services = productService;
        }

        public async Task<IActionResult> Index()
        {
            var customResponse = await _services.GetProductsWithCategory();
            return View(customResponse);
        }
    }
}