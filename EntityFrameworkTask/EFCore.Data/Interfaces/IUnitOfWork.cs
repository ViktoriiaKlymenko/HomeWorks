using EntityFrameworkTask;
using System;

namespace EFCore.Data.Interfaces
{
<<<<<<< HEAD
    public interface IUnitOfWork : IDisposable
=======
    public interface IUnitOfWork: IDisposable
>>>>>>> Task4-APILayer
    {
        IBaseRepository<Product> Products { get; }
        IBaseRepository<Order> Orders { get; }
        IBaseRepository<Provider> Providers { get; }
        IBaseRepository<Client> Clients { get; }
        IBaseRepository<Category> Categories { get; }
        IBaseRepository<Courier> Couriers { get; }
<<<<<<< HEAD

        int Complete();
    }
}
=======
        int Complete();
    }
}
>>>>>>> Task4-APILayer
