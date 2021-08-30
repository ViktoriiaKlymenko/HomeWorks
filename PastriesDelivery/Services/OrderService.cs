using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PastriesDelivery
{
    public class OrderService
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly ILogger _logger;
        protected readonly IProductService _productService;

        public OrderService(IUnitOfWork unitOfWork, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public Product ChooseProduct(int id, int amount)
        {
            var availableProducts = _productService.ExtractProducts();
            var product = availableProducts.FirstOrDefault(p => p.Id == id);
            if (amount > product.Amount || amount <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (amount < product.Amount)
            {
                _unitOfWork.Products.Find(p => p.Id == id).Amount -= amount;
                _logger.Log($"{amount} units of {product.ToString()} were removed from available products.");
                return product;
            }

            if (product.Amount == amount)
            {
                _unitOfWork.Products.Remove(availableProducts.FirstOrDefault(product => product.Id == id));
                _logger.Log($"{product.ToString()} was removed from available products.");
                return product;
            }

            return product;
        }

        public bool CheckForDataPrescence()
        {
            return _unitOfWork.Products.Count() is not 0;
        }

        public virtual void CreateOrder(int clientId, int productId, decimal totalPrice, OrderStatus status, int courierId, decimal deliveryPrice)
        {
            _unitOfWork.Orders.Add(new Order(_unitOfWork.Orders.GetMaxId() + 1, clientId, productId, totalPrice, status, courierId, deliveryPrice));
        }
    }
}