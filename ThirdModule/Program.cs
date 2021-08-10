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
            var sortedProducts = SortProducts(products);

            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product.Name);
            }

            Console.WriteLine("--------------------------------");
            var productsAndProviders = GetProductsAndProviders(products);

            foreach (var productAndProvider in productsAndProviders)
            {
                Console.WriteLine($"{productAndProvider}");
            }

            Console.WriteLine("--------------------------------");
            var categoriesAndAmountOfProducts = GetCategoriesAndProductsAmount(products);

            foreach (var categoryAndAmountOfProducts in categoriesAndAmountOfProducts)
            {
                Console.WriteLine($"{categoryAndAmountOfProducts}");
            }

            Console.WriteLine("--------------------------------");
            var providersAndProductsAmount = GetProvidersAndProductsAmount(products);
            foreach (var providerAndProductAmount in providersAndProductsAmount)
            {
                Console.WriteLine($"{providerAndProductAmount}");
            }

            Console.WriteLine("--------------------------------");
           
            var nonUniqueProducts = GetNonUniqueProducts(products); 
            var uniqueProducts = GetUniqueProducts(products); 
            Console.WriteLine("Unique products:");

            foreach (var uniqueProduct in uniqueProducts)
            {
                Console.WriteLine($"{uniqueProduct.Name}");
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Non-unique products:");

            foreach (var nonUniqueProduct in nonUniqueProducts)
            {
                Console.WriteLine($"{nonUniqueProduct.Name}");
            }

            Console.WriteLine("--------------------------------");
            Console.ReadKey();
        }

        public static List<Product> SortProducts(List<Product> products)
        {
            return products.OrderBy(product => product.Name).ToList();
        }

        private static List<Product> GetUniqueProducts(List<Product> products)
        {
            var productsOfFirstProvider = products.Where(product => product.Provider.Name == "Dinner in the Sky");
            var productsOfSecondProvider = products.Where(product => product.Provider.Name == "The Disaster Café");
            return productsOfFirstProvider.Except(productsOfSecondProvider).Concat(productsOfSecondProvider.Except(productsOfFirstProvider)).ToList();
        }

        private static List<Product> GetNonUniqueProducts(List<Product> products)
        {
            var productsOfFirstProvider = products.Where(product => product.Provider.Name == "Dinner in the Sky");
            var productsOfSecondProvider = products.Where(product => product.Provider.Name == "The Disaster Café");
            return productsOfFirstProvider.Intersect(productsOfSecondProvider).ToList();
        }

        private static List<string> GetProvidersAndProductsAmount(List<Product> products)
        {
            var tuple = (products.GroupBy(product => product.Provider)
                .Select(product => product.Key.Name)
                .OrderByDescending(product => product.Count())
                .ToList(), products
                .GroupBy(product => product.Provider)
                .Select(product => product.Count()).OrderByDescending(product => product).ToList());
            var providersAndAmountOfProducts = tuple.Item1.Zip(tuple.Item2, (provider, productsAmount) => Convert.ToString($"{provider} - {productsAmount}")).ToList();
            return providersAndAmountOfProducts;
        }

        private static List<string> GetCategoriesAndProductsAmount(List<Product> products)
        {
            var CategoriesAndProductsAmount = products.GroupBy(product => product.Category)
                .Select(product =>  Convert.ToString($"{product.Key.Name} - {product.Count()}")).ToList();
                return CategoriesAndProductsAmount;
        }

        private static List<string> GetProductsAndProviders(List<Product> products)
        {
            return products.Select(product => Convert.ToString($"{product.Name} - {product.Provider.Name}")).ToList();
        }

        private static List<string> GetProductsAndProvidersAnother(List<Product> products)
        {
            return products.Select(product => Convert.ToString($"{product.Name} - {product.Provider.Name}")).ToList();
        }
    }
}
