﻿using EntityFrameworkTask;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplicationFoodService.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        // GET: OrderController
        public IEnumerable<Order> GetAll()
        {
            return _orderService.GetAll();
        }
        public void Remove(Order order)
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
    }
}
