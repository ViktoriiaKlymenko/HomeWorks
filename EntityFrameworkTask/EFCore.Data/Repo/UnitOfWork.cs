using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using EntityFrameworkTask.EFCore.Data;
using EntityFrameworkTask.EFCore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
            Providers = new BaseRepository<Provider>(_context);
            Clients = new BaseRepository<Client>(_context);
            Couriers = new BaseRepository<Courier>(_context);
            Orders = new OrderRepository(_context);
            Categories = new BaseRepository<Category>(_context);
        }

        public IProductRepository Products { get; private set; }

        public IOrderRepository Orders { get; private set; }

        public IBaseRepository<Provider> Providers { get; private set; }

        public IBaseRepository<Client> Clients { get; private set; }

        public IBaseRepository<Category> Categories { get; private set; }

        public IBaseRepository<Courier> Couriers { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
