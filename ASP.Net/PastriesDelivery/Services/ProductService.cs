using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System;
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
        private readonly ILogger _logger;

        public ProductService(IUnitOfWork unitOfWork, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public List<Product> ExtractProducts()
        {
            return _unitOfWork.Products.GetAll().ToList();
        }
        public void AddProduct(string name, decimal price, int amount, double weight, int categoryId, int providerId)
        {
            _unitOfWork.Products.Add(new Product(name, price, amount, weight, categoryId, providerId));
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
            return _unitOfWork.Products.GetAll().Where(p => p.ProviderId == id);
        }

        public void UpdateProduct(Product product, Product newProduct)
        {
            _unitOfWork.Products.Update(product, newProduct);
            _unitOfWork.Complete();
        }
    }
}