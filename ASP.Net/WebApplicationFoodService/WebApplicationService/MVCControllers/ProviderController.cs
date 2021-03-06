using EntityFrameworkTask.Models;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Contracts;
using System.Collections.Generic;

namespace WebApplicationService.Controllers
{
    [Controller]
    public class ProviderController : Controller
    {
        private readonly IProviderService _providerService;

        public ProviderController(IProviderService providerService)
        {
            _providerService = providerService;
        }

        [HttpGet]
        public IEnumerable<Provider> GetAll()
        {
            return _providerService.GetProviders();
        }

        [HttpPost]
        public IActionResult CreateProvider(Provider provider)
        {
            _providerService.AddProvider(provider);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProvider(Provider provider, Provider newProvider)
        {
            _providerService.UpdateProvider(provider, newProvider);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProvider(Provider provider)
        {
            _providerService.DeleteProvider(provider);
            return Ok();
        }
    }
}