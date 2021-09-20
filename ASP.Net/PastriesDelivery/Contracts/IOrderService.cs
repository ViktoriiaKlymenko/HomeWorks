using EntityFrameworkTask;
using EntityFrameworkTask.Models;
using System.Collections.Generic;

namespace PastriesDelivery.Contracts
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAll();

        void CreateOrder(int clientId, int productId, int amount, decimal totalPrice, int courierId);

        void Remove(Order order);

        IEnumerable<Order> GetClientOrders(int clientId);

        void ChangeOrderStatus(Order order, OrderStatus newStatus);

        void UpdateOrder(Order order, Order newOrder);
    }
}