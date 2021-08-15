using EFCore.Data.Interfaces;
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
            Providers = new ProviderRepository(_context);
            Clients = new ClientRepository(_context);
            Couriers = new CourierRepository(_context);
            Orders = new OrderRepository(_context);
            Categories = new CategoryRepository(_context);
        }

        public IProductRepository Products { get; private set; }

        public IOrderRepository Orders { get; private set; }

        public IProviderRepository Providers { get; private set; }

        public IClientRepository Clients { get; private set; }

        public ICategoryRepository Categories { get; private set; }

        public ICourierRepository Couriers { get; private set; }

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
