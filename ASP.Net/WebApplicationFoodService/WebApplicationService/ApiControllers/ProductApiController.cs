using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Contracts;
using System.Text.Json;

namespace WebApplicationFoodService.ApiControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductApiController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public string Get()
        {
            return JsonSerializer.Serialize(_productService.ExtractProducts());
        }

        [HttpPost]
        public string CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product.Name, product.Price, product.Amount, product.Weight, product.Category, product.Provider);
            }
            return JsonSerializer.Serialize(new Product(product.Name, product.Price, product.Amount, product.Weight, product.Category, product.Provider));
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