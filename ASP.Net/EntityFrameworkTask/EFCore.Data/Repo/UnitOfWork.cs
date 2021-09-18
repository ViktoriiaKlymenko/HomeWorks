using EFCore.Data.Interfaces;
using EntityFrameworkTask;

namespace EFCore.Data.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
            Products = new BaseRepository<Product>(_context);
            Providers = new BaseRepository<Provider>(_context);
            Clients = new BaseRepository<Client>(_context);
            Couriers = new BaseRepository<Courier>(_context);
            Orders = new BaseRepository<Order>(_context);
            Categories = new BaseRepository<Category>(_context);
        }

        public IBaseRepository<Product> Products { get; private set; }

        public IBaseRepository<Order> Orders { get; private set; }

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