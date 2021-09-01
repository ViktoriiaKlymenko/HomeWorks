using EFCore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTask.EFCore.Data.Interfaces
{
    public interface IOrderRepository: IBaseRepository<Order>
    {
        void ChangeOrderStatus(Order order, OrderStatus newStatus);
    }
}
