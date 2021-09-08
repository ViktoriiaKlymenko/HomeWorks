using EntityFrameworkTask;
using EntityFrameworkTask.EFCore.Data.Interfaces;

namespace EFCore.Data
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(DataContext context) : base(context)
        {
        }

        public void ChangeOrderStatus(Order order, OrderStatus newStatus)
        {
            Context.Set<Order>().Update(order).CurrentValues.SetValues(order.Status = newStatus);
        }
    }
}