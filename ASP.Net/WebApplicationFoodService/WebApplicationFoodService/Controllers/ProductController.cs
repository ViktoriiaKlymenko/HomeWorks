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
<<<<<<< HEAD
        private readonly ICustomerManager _customerManager;

        public ProductController(ILogger<ProductController> logger, ICustomerManager customerManager)
=======
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
>>>>>>> Task4-APILayer
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
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromQuery] Product product, [FromBody] Product newProduct)
        {
            _productService.UpdateProduct(product, newProduct);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProduct(Product product)
        {
            _productService.Remove(product);
            return Ok();
        }
    }
}