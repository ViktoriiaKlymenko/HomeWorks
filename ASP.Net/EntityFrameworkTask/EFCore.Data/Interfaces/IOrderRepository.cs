using EFCore.Data.Interfaces;

namespace EntityFrameworkTask.EFCore.Data.Interfaces
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        void ChangeOrderStatus(Order order, OrderStatus newStatus);
    }
}