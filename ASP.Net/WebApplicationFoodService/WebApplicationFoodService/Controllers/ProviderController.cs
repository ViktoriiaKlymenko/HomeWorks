using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFoodService.Controllers
{
    public class ProviderController : Controller
    {
        private readonly IProviderService _providerService;

        [HttpGet]
        public IEnumerable<Provider> GetAll()
        {
            return _providerService.GetProviders();
        }

        [HttpPost]
        public IActionResult CreateProvider(Provider provider)
        {
            _providerService.AddProvider(provider);
            return new OkResult();
        }

        [HttpPut]
        public IActionResult UpdateProvider(Provider provider, Provider newProvider)
        {
            _providerService.UpdateProvider(provider, newProvider);
            return new OkResult();
        }

        [HttpDelete]
        public IActionResult DeleteProvider(Provider provider)
        {
            _providerService.DeleteProvider(provider);
            return new OkResult();
        }
    }
}
