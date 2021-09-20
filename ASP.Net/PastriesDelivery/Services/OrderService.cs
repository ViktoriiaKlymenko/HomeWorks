using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using EntityFrameworkTask.Models;
using PastriesDelivery.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PastriesDelivery
{
    public class OrderService : IOrderService
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IProductService _productService;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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
                return product;
            }

            if (product.Amount == amount)
            {
                _unitOfWork.Products.Remove(availableProducts.FirstOrDefault(product => product.Id == id));
                return product;
            }

            return product;
        }

        public bool CheckForDataPrescence()
        {
            return _unitOfWork.Products.Count() is not 0;
        }

        public virtual void CreateOrder(int clientId, int productId, int amount, decimal totalPrice, int courierId)
        {
            _unitOfWork.Orders.Add(new Order());
            _unitOfWork.Complete();
        }

        public void ChangeOrderStatus(Order order, OrderStatus newStatus)
        {
            _unitOfWork.Orders.ChangeOrderStatus(order, newStatus);
        }

        public IEnumerable<Order> GetAll()
        {
            return _unitOfWork.Orders.GetAll();
        }

        public void Remove(Order order)
        {
            _unitOfWork.Orders.Remove(order);
            _unitOfWork.Complete();
        }

        public IEnumerable<Order> GetClientOrders(int clientId)
        {
            return _unitOfWork.Orders.GetAll().Where(o => o.Client.Id == clientId);
        }

        public void UpdateOrder(Order order, Order newOrder)
        {
            _unitOfWork.Orders.Update(order, newOrder);
            _unitOfWork.Complete();
        }
    }
}