using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PastriesDelivery.Contracts;
using System.Linq;

namespace WebApplicationService.Controllers
{
    [Controller]
    [Route("mvc/[controller]")]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IProviderService _providerService;

        public ProductController(ILogger<ProductController> logger, IProductService productService, ICategoryService categoryService, IProviderService providerService)
        {
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService;
            _providerService = providerService;
        }

        [HttpGet("Get")]
        public IActionResult Get()
        {
            return View("Get", _productService.ExtractProducts());
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            ViewData["Categories"] = _categoryService.GetCategories();
            ViewData["Providers"] = _providerService.GetProviders();
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(Product product)
        {
            product.Category = _categoryService.GetCategories().FirstOrDefault(c => c.Id == product.Category.Id);
            product.Provider = _providerService.GetProviders().FirstOrDefault(p => p.Id == product.Provider.Id);

            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
                return RedirectToAction("Get", "Product");
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet("Update/{id}")]
        public IActionResult Update(int id)
        {
            if (id > 0)
            {
                var product = _productService.GetById(id);

                if (product != null)
                {
                    ViewData["Categories"] = _categoryService.GetCategories();
                    ViewData["Providers"] = _providerService.GetProviders();
                    return View("Create", product);
                }
            }
            return NotFound();
        }

        [HttpPost("Update")]
        public IActionResult Update(Product product)
        {
            _productService.UpdateProduct(product);
            return RedirectToAction("Index");
        }

        [HttpGet("Delete/{id}")]
        public IActionResult Delete(int id)
        {

            if (_productService.GetById(id) == null || id == 0)
            {
                return NotFound();
            }

            _productService.Remove(id);
            return RedirectToAction("Index", "Home");
        }
    }
}