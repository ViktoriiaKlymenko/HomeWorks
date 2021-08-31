using EntityFrameworkTask;
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
        public IEnumerable<Order> Get()
        {
            return _orderService.GetAll();
        }
        public void Remove(Order order)
        {
            _orderService.Remove(order);
        }
    }
}
