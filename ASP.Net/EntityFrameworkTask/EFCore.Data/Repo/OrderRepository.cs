using EFCore.Data;
using EntityFrameworkTask.EFCore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkTask.EFCore.Data;
using EntityFrameworkTask;

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

        public void ChangeOrderAmount(Order order, int newValue)
        {
            Context.Set<Order>().Update(order).CurrentValues.SetValues(order.Amount = newValue);
        }
    }
}
