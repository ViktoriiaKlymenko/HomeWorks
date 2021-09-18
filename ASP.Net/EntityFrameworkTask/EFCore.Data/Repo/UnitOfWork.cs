using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using EntityFrameworkTask.EFCore.Data.Interfaces;

namespace EFCore.Data.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(
            DataContext context,
            IBaseRepository<Product> productRepository, 
            IBaseRepository<Provider> providerRepository, 
            IBaseRepository<Client> clientRepository,
            IBaseRepository<Courier> courierRepository,
            IOrderRepository orderRepository,
            IBaseRepository<Category> categoryRepository
            )
        {
            _context = context;
            Products = productRepository;
            Providers = providerRepository;
            Clients = clientRepository;
            Couriers = courierRepository;
            Orders = orderRepository;
            Categories = categoryRepository;
        }

        private readonly IBaseRepository<Product> Products;

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