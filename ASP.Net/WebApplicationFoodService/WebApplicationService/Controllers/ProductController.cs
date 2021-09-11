using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PastriesDelivery.Contracts;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebApplicationService.Models;

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

        public IActionResult Create()
        {
            ViewData["Categories"] = _categoryService.GetCategories();
            ViewData["Providers"] = _providerService.GetProviders();
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public IActionResult Create(Product product)
        {
            product.Category = _categoryService.GetCategories().FirstOrDefault(c => c.Id == product.Category.Id);
            product.Provider = _providerService.GetProviders().FirstOrDefault(p => p.Id == product.Provider.Id);

            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
            }
            return RedirectToAction("Index", "Home");
        }

        //public IActionResult Update(int id)
        //{
        //    ViewData["Categories"] = _categoryService.GetCategories();
        //    ViewData["Providers"] = _providerService.GetProviders();
        //    return View("Create", _productService.GetById(id));
        //}

        //[HttpPut]
        //public IActionResult Update(int id, Product newProduct)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _productService.UpdateProduct(id, newProduct);
        //    }
        //    return RedirectToAction("Index", "Home");
        //}

        //public IActionResult Delete(int id)
        //{
        //    return View("Delete");
        //}

        //[HttpDelete("{id}")]
        //[ActionName("Delete")]
        //public IActionResult Delete()
        //{
        //    _productService.Remove(id);
        //    return RedirectToAction("Index", "Home");
        //}
        [HttpGet("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            _productService.Remove(id);

            return RedirectToAction("Index", "Home");
        }
    }
}