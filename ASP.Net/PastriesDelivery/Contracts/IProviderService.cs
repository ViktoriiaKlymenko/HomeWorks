using EntityFrameworkTask.Models;
using System.Collections.Generic;

namespace PastriesDelivery.Contracts
{
    public interface IProviderService
    {
        void AddProvider(Provider provider);

        void UpdateProvider(Provider provider, Provider newProvider);

        void DeleteProvider(Provider provider);

        Provider GetProvider(int id);

        IEnumerable<Provider> GetProviders();
    }
}