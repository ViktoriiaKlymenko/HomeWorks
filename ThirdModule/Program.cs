using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdModule
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = new List<ProviderType>
            {
                new ProviderType() { Id = new Guid(), Name = "Cafe"},
                new ProviderType() { Id = new Guid(), Name = "Fast Food Restaurant"},
                new ProviderType() { Id = new Guid(), Name = "Ghost Restaurant"},
                new ProviderType() { Id = new Guid(), Name = "Cafeteria"}
            };
            var providers = new List<Provider>
            {
                new Provider() { Id = new Guid(), Name = "The Disaster Café", Type = types.ElementAt(0)},
                new Provider() { Id = new Guid(), Name = "Parallax Restaurant", Type = types.ElementAt(1)},
                new Provider() { Id = new Guid(), Name = "Eternity", Type = types.ElementAt(2)},
                new Provider() { Id = new Guid(), Name = "Dinner in the Sky", Type = types.ElementAt(3)},
                new Provider() { Id = new Guid(), Name = "Norma's", Type = types.ElementAt(3)},
            };
            var categories = new List<Category>
            {
                new Category() { Id = new Guid(), Name = "Cake" },
                new Category() { Id = new Guid(), Name ="Pie"},
                new Category() { Id = new Guid(), Name ="Eclair"},
                new Category() { Id = new Guid(), Name ="Bun" },
                new Category() { Id = new Guid(), Name ="Puff" }
            };
            var products = new List<Product>
            {
                new Product() {Id = new Guid(), Name="Pound Cake", Category=categories.ElementAt(0), Price=10, Provider = providers.ElementAt(0) },
                new Product() {Id = new Guid(), Name="Cream Pie", Category=categories.ElementAt(1), Price=20, Provider = providers.ElementAt(1) },
                new Product() {Id = new Guid(), Name="Brunetti", Category=categories.ElementAt(2), Price=30, Provider = providers.ElementAt(3) },
                new Product() {Id = new Guid(), Name="Cinnamon Bun", Category=categories.ElementAt(3), Price=40, Provider = providers.ElementAt(2) },
                new Product() {Id = new Guid(), Name="Puff Snowmen", Category=categories.ElementAt(4), Price=50, Provider = providers.ElementAt(4) }
            };
            Console.WriteLine("--------------------------------");
            Console.WriteLine("List of products sorted by name:");

            foreach (var product in products.OrderBy(product => product.Name))
            {
                Console.WriteLine(product.Name);
            }

            Console.WriteLine("--------------------------------");
            var productsAndProviders = products.Select(product => new { productName = product.Name, productProvider = product.Provider.Name });

            foreach (var productAndProvider in productsAndProviders)
            {
                Console.WriteLine($"{productAndProvider.productName} - {productAndProvider.productProvider}");
            }

            Console.WriteLine("--------------------------------");
            var categoriesAndAmountOfProducts = products.GroupBy(product => product.Category).Select(product => new { categoryName = product.Key.Name, productsAmount = product.Count()});

            foreach (var categoryAndAmountOfProducts in categoriesAndAmountOfProducts)
            {
                Console.WriteLine($"{categoryAndAmountOfProducts.categoryName} - {categoryAndAmountOfProducts.productsAmount}");
            }

            Console.WriteLine("--------------------------------");
            var providersAndProducts = products.GroupBy(product => product.Provider).Select(product => new { provider = product.Key.Name, productsAmount = product.Count()}).OrderByDescending(product => product.productsAmount);

            foreach (var providerAndProducts in providersAndProducts)
            {
                Console.WriteLine($"{providerAndProducts.provider} - {providerAndProducts.productsAmount}");
            }

            Console.ReadKey();
        }
    }
}
