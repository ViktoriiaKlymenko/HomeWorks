using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System.Collections.Generic;
using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with provider.
    /// </summary>
    public class ProductService
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
            _unitOfWork.Products.Add(new Product(_unitOfWork.Products.GetMaxId() + 1, name, price, amount, weight, categoryId, providerId));
        }
    }
}