using EntityFrameworkTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastriesDelivery.Contracts
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAll();
        void CreateOrder(int clientId, int productId, decimal totalPrice, OrderStatus status, int courierId, decimal deliveryPrice);
        void Remove(Order order);
    }
}
