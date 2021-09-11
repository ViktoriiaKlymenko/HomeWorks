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

        public IEnumerable<Product> ExtractProducts()
        {
            return _unitOfWork.Products.GetAll();
        }

        public void AddProduct(Product product)
        {
            _unitOfWork.Products.Add(product);
            _unitOfWork.Complete();
        }

        public IEnumerable<string> GetProviders()
        {
            return _unitOfWork.Providers.GetAll().Select(p => p.Name);
        }

        public void Remove(int id)
        {
            _unitOfWork.Products.Remove(_unitOfWork.Products.Get(id));
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

        public void UpdateProduct(int id, Product newProduct)
        {
            _unitOfWork.Products.Update(_unitOfWork.Products.Get(id), newProduct);
            _unitOfWork.Complete();
        }

        public Product GetById(int id)
        {
           return _unitOfWork.Products.Get(id);
        }
    }
}