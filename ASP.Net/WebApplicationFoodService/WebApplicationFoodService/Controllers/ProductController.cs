using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PastriesDelivery;
using System.Collections.Generic;

namespace WebApplicationFoodService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.ExtractProducts();
        }

        [HttpPost]
        public IActionResult CreateProduct(string name, decimal price, int amount, double weight, int categoryId, int providerId)
        {
            _productService.AddProduct(name, price, amount, weight, categoryId, providerId);
            return new OkResult();
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromQuery] Product product, [FromBody] Product newProduct)
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
    }
}