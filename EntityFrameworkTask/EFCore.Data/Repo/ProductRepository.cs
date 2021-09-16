using EntityFrameworkTask;
using System.Collections.Generic;
using System.Linq;

namespace EFCore.Data.Repo
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }

        public IEnumerable<Product> SortByPrice()
        {
            return Context.Set<Product>().OrderBy(product => product).ToList();
        }
    }
}