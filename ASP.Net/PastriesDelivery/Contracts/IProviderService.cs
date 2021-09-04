using EntityFrameworkTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery.Contracts
{
    public interface IProviderService
    {
        void AddProvider(Provider provider);
        void UpdateProvider(Provider provider, Provider newProvider);
        void DeleteProvider(Provider provider);
        Provider GetProvider(int id);
        IEnumerable<Provider> GetClients();
    }
}
