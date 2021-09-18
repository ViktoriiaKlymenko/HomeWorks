using EntityFrameworkTask;
using System;

namespace EFCore.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        IBaseRepository<Order> Orders { get; }
        IBaseRepository<Provider> Providers { get; }
        IBaseRepository<Client> Clients { get; }
        IBaseRepository<Category> Categories { get; }
        ICourierRepository Couriers { get; }

        int Complete();
    }
}