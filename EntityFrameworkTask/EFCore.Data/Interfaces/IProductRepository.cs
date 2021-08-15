using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System.Collections.Generic;

namespace EFCore.Data
{
    public interface IProductRepository: IBaseRepository<Product>
    {
        public IEnumerable<Product> SortByPrice();
    }
}