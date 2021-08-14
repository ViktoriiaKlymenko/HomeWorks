using EntityFrameworkTask;
using System.Collections.Generic;

namespace EFCore.Data
{
    internal interface IProductRepository
    {
        public IEnumerable<Product> SortByPrice();
    }
}