using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using PastriesDelivery.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with provider.
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Product> ExtractProducts()
        {
            return _unitOfWork.Products.GetAll().ToList();
        }

        public void AddProduct(string name, decimal price, int amount, double weight, Category category, Provider provider)
        {
            _unitOfWork.Products.Add(new Product(name, price, amount, weight, category, provider));
            _unitOfWork.Complete();
        }

        public IEnumerable<string> GetProviders()
        {
            return _unitOfWork.Providers.GetAll().Select(p => p.Name);
        }

        public void Remove(Product product)
        {
            _unitOfWork.Products.Remove(product);
            _unitOfWork.Complete();
        }

        public IEnumerable<Product> SortByPrice()
        {
            return _unitOfWork.Products.GetAll().OrderBy(p => p.Price);
        }

        public IEnumerable<Product> GetProviderDishes(int id)
        {
            return _unitOfWork.Products.GetAll().Where(p => p.Provider.Id == id);
        }

        public void UpdateProduct(Product product, Product newProduct)
        {
            _unitOfWork.Products.Update(product, newProduct);
            _unitOfWork.Complete();
        }
    }
}