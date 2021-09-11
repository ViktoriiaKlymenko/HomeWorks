using EntityFrameworkTask;
using System.Collections.Generic;

namespace PastriesDelivery.Contracts
{
    public interface IProductService
    {
        List<Product> ExtractProducts();

        IEnumerable<string> GetProviders();

        IEnumerable<Product> SortByPrice();

        IEnumerable<Product> GetProviderDishes(int id);

        void AddProduct(string name, decimal price, int amount, double weight, Category category, Provider provider);

        void UpdateProduct(Product product, Product newProduct);

        void Remove(Product product);
    }
}