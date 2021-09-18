using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Contracts;
using System.Collections.Generic;

namespace WebApplicationFoodService.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IEnumerable<Order> GetAll()
        {
            return _orderService.GetAll();
        }

        [HttpDelete]
        public IActionResult DeleteOrder(Order order)
        {
            _orderService.Remove(order);
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateOrder(int clientId, int productId, int amount, decimal totalPrice, int courierId)
        {
            _orderService.CreateOrder(clientId, productId, amount, totalPrice, courierId);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateOrder(Order order, Order newOrder)
        {
            _orderService.UpdateOrder(order, newOrder);
            return Ok();
        }
    }
}