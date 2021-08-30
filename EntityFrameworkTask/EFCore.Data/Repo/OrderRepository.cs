using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Repo
{
    public class OrderRepository: BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(DataContext context) : base(context)
        {
           
        }
        public int GetMaxId()
        {
            return Context.Set<Order>().Max<Order>(p => p.Id);
        }
    }
}
