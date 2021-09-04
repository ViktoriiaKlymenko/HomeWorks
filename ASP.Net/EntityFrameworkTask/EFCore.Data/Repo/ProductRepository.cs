using EntityFrameworkTask;
using EntityFrameworkTask.EFCore.Data.Interfaces;

namespace EFCore.Data
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}