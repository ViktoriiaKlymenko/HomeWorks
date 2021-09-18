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
        void CreateOrder(int clientId, int productId, int amount, decimal totalPrice, int courierId);
        void Remove(Order order);
        IEnumerable<Order> GetClientOrders(int clientId);
        void ChangeOrderStatus(Order order, OrderStatus newStatus);
    }
}
