using EntityFrameworkTask;
using System.Collections.Generic;

namespace PastriesDelivery
{
    public interface IProductService
    {
        List<Product> ExtractProducts();
        IEnumerable<string> GetProviders();
        IEnumerable<Product> SortByPrice();
        IEnumerable<Product> GetProviderDishes(int id);
    }
}