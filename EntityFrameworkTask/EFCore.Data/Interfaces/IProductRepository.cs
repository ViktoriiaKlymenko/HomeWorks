using EntityFrameworkTask;
using System.Collections.Generic;

namespace EFCore.Data
{
    public interface IProductRepository
    {
        public IEnumerable<Product> SortByPrice();
    }
}