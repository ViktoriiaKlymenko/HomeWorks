using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        IProviderRepository Providers { get; }
        IClientRepository Clients { get; }
        ICategoryRepository Categories { get; }
        ICourierRepository Couriers { get; }
        int Complete();
    }
}
