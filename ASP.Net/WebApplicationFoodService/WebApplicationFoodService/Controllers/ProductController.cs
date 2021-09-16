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
        private readonly ICustomerManager _customerManager;

        public ProductController(ILogger<ProductController> logger, ICustomerManager customerManager)
        {
            _logger = logger;
            _customerManager = customerManager;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _customerManager.ExtractProducts().ToArray();
        }
    }
}