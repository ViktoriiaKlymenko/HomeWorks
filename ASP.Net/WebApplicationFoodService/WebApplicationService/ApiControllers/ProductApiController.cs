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

        [HttpGet("Get")]
        public IActionResult Get()
        {
            //return JsonSerializer.Serialize(_productService.ExtractProducts());
            return Ok(_productService.ExtractProducts());
        }

        [HttpPost("Create")]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
            }
            return Ok(product);
        }

        [HttpPut("Update")]
        public IActionResult UpdateProduct(int id, [FromBody] Product newProduct)
        {
            _productService.UpdateProduct(id, newProduct);
            return Ok(newProduct);
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteProduct([FromBody] int id)
        {
            _productService.Remove(id);
            return Ok(_productService.GetById(id));
        }
    }
}