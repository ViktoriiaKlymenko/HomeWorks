using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System.Collections.Generic;

namespace EFCore.Data
{
    public interface IProductRepository: IBaseRepository<Product>
    {
        IEnumerable<Product> SortByPrice();
        int GetMaxId();
    }
}