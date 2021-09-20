using EFCore.Data.Interfaces;
using EntityFrameworkTask.Models;

namespace EntityFrameworkTask.EFCore.Data.Interfaces
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        void ChangeOrderStatus(Order order, OrderStatus newStatus);
    }
}