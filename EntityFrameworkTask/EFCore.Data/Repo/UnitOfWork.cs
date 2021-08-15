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
            var products = new ProductRepository(_context);
            var providers = new ProviderRepository(_context);
            var clients = new ClientRepository(_context);
            var couriers = new CourierRepository(_context);
            var orders = new OrderRepository(_context);
            var categories = new CategoryRepository(_context);
        }

        public IProductRepository Products => throw new NotImplementedException();

        public IOrderRepository Orders => throw new NotImplementedException();

        public IProviderRepository Providers => throw new NotImplementedException();

        public IClientRepository Clients => throw new NotImplementedException();

        public ICategoryRepository Categories => throw new NotImplementedException();

        public ICourierRepository Couriers => throw new NotImplementedException();

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
