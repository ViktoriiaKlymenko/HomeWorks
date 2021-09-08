using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Contracts;
using System.Collections.Generic;

namespace WebApplicationService.Controllers
{
    public class ProviderController : Controller
    {
        private readonly IProviderService _providerService;

        public IEnumerable<Provider> GetAll()
        {
            return _providerService.GetProviders();
        }

        public Provider GetById(int id)
        {
            return _providerService.GetProvider(id);
        }

        public IActionResult CreateProvider(Provider provider)
        {
            _providerService.AddProvider(provider);
            return new OkResult();
        }

        public IActionResult UpdateProvider(Provider provider, Provider newProvider)
        {
            _providerService.UpdateProvider(provider, newProvider);
            return new OkResult();
        }

        public IActionResult DeleteProvider(Provider provider)
        {
            _providerService.DeleteProvider(provider);
            return new OkResult();
        }
    }
}