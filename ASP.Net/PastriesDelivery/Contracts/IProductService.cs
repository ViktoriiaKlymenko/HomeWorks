using EntityFrameworkTask.Models;
using System.Collections.Generic;

namespace PastriesDelivery.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> ExtractProducts();

        IEnumerable<string> GetProviders();

        IEnumerable<Product> SortByPrice();

        IEnumerable<Product> GetProviderDishes(int id);

        void AddProduct(Product product);

        void UpdateProduct(Product newProduct);

        void Remove(int id);

        Product GetById(int id);
    }
}