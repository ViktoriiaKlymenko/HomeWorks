using EntityFrameworkTask.Models;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Contracts;

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
            return Ok(_productService.ExtractProducts());
        }

        [HttpPost("Create")]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
                return Ok(product);
            }

            return BadRequest();
        }

        [HttpPut("Update")]
        public IActionResult UpdateProduct([FromBody] Product newProduct)
        {
            if (ModelState.IsValid)
            {
                _productService.UpdateProduct(newProduct);
                return Ok(newProduct);
            }

            return BadRequest();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteProduct(int id)
        {
            if (id == 0 || _productService.GetById(id) == null)
            {
                return BadRequest();
            }

            _productService.Remove(id);
            return Ok(_productService.GetById(id));
        }
    }
}