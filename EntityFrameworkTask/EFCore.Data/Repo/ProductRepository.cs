using EntityFrameworkTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Repo
{
    public class ProductRepository: BaseRepository<Product>, IProductRepository
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
