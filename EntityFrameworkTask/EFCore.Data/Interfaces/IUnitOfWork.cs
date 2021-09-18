using EntityFrameworkTask;
using System;

namespace EFCore.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Product> Products { get; }
        IBaseRepository<Order> Orders { get; }
        IBaseRepository<Provider> Providers { get; }
        IBaseRepository<Client> Clients { get; }
        IBaseRepository<Category> Categories { get; }
        IBaseRepository<Courier> Couriers { get; }

        int Complete();
    }
}