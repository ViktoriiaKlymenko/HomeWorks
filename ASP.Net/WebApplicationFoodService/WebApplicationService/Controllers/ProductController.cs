using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PastriesDelivery;
using System.Collections.Generic;
using System.Diagnostics;
using WebApplicationService.Models;

namespace WebApplicationService.Controllers
{
    [ApiController]
    [Route("mvc/[controller]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return View("Product", _productService.ExtractProducts());
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product.Name, product.Price, product.Amount, product.Weight, product.Category, product.Provider);
            }
            return new OkResult();
        }

        public IEnumerable<string> GetProviders()
        {
            return _productService.GetProviders();
        }

        public IEnumerable<Product> GetProviderDishes(int id)
        {
            return _productService.GetProviderDishes(id);
        }

        public IEnumerable<Product> SortByPrice()
        {
            return _productService.SortByPrice();
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromBody] Product product, [FromQuery] Product newProduct)
        {
            _productService.UpdateProduct(product, newProduct);
            return new OkResult();
        }

        [HttpDelete]
        public IActionResult DeleteProduct(Product product)
        {
            _productService.Remove(product);
            return new OkResult();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}