using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PastriesDelivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFoodService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        // GET 
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var customerManager = new СustomerManager(new Storage(), new CurrencyService());
            return customerManager.ExtractProducts().ToArray();
        }
    }
}
