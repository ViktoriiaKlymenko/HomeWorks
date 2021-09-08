using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Contracts;
using System.Collections.Generic;

namespace WebApplicationFoodService.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public IEnumerable<Order> GetAll()
        {
            return _orderService.GetAll();
        }

        public IActionResult DeleteOrder(Order order)
        {
            _orderService.Remove(order);
            return new OkResult();
        }

        public IEnumerable<Order> GetClientOrders(int clientId)
        {
            return _orderService.GetClientOrders(clientId);
        }

        public IActionResult CreateOrder(int clientId, int productId, int amount, decimal totalPrice, int courierId)
        {
            _orderService.CreateOrder(clientId, productId, amount, totalPrice, courierId);
            return new OkResult();
        }

        public IActionResult ChangeOrderStatus(Order order, OrderStatus newStatus)
        {
            _orderService.ChangeOrderStatus(order, newStatus);
            return new OkResult();
        }

        public IActionResult UpdateOrder(Order order, Order newOrder)
        {
            _orderService.UpdateOrder(order, newOrder);
            return new OkResult();
        }
    }
}