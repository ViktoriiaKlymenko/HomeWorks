using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Contracts;
using System.Collections.Generic;

namespace WebApplicationService.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public IEnumerable<Order> GetAll()
        {
            return _orderService.GetAll();
        }

        public void DeleteOrder(Order order)
        {
            _orderService.Remove(order);
        }

        public IEnumerable<Order> GetClientOrders(int clientId)
        {
            return _orderService.GetClientOrders(clientId);
        }

        public void CreateOrder(int clientId, int productId, int amount, decimal totalPrice, int courierId)
        {
            _orderService.CreateOrder(clientId, productId, amount, totalPrice, courierId);
        }

        public void ChangeOrderStatus(Order order, OrderStatus newStatus)
        {
            _orderService.ChangeOrderStatus(order, newStatus);
        }

        public void UpdateOrder(Order order, Order newOrder)
        {
            _orderService.UpdateOrder(order, newOrder);
        }
    }
}