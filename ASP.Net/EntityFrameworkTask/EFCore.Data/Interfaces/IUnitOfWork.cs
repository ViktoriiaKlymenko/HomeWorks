using EntityFrameworkTask;
using EntityFrameworkTask.EFCore.Data.Interfaces;
using System;

namespace EFCore.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        IBaseRepository<Provider> Providers { get; }
        IBaseRepository<Client> Clients { get; }
        IBaseRepository<Category> Categories { get; }
        IBaseRepository<Courier> Couriers { get; }

        int Complete();
    }
}