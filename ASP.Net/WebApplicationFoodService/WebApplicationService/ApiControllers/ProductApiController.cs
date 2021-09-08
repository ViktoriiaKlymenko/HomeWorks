using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PastriesDelivery;
using System.Collections.Generic;
using System.Text.Json;

namespace WebApplicationFoodService.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        //private readonly ILogger _logger;
        private readonly IProductService _productService;

        public ProductApiController(IProductService productService)
        {
            //_logger = logger;
            _productService = productService;
        }

        [HttpGet]
        public string Get()
        {
            return JsonSerializer.Serialize(_productService.ExtractProducts());
        }

        [HttpPost]
        public string CreateProduct(string name, decimal price, int amount, double weight, int categoryId, int providerId)
        {
            if (ModelState.IsValid)
            {
               _productService.AddProduct(name, price, amount, weight, categoryId, providerId);
            }
            return JsonSerializer.Serialize(new Product(name, price, amount, weight, categoryId, providerId));
        }

        [HttpPut]
        public string UpdateProduct([FromQuery] Product product, [FromBody] Product newProduct)
        {
            _productService.UpdateProduct(product, newProduct);
            return JsonSerializer.Serialize(newProduct);
        }

        [HttpDelete]
        public string DeleteProduct(Product product)
        {
            _productService.Remove(product);
            return JsonSerializer.Serialize(product);
        }
    }
}
