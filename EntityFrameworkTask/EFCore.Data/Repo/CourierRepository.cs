using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Repo
{
    public class CourierRepository: BaseRepository<Courier>, ICourierRepository
    {
        public CourierRepository(DataContext context) : base(context)
        {
        }

        public IEnumerable<Courier> SortBySalary()
        {
            return Context.Set<Courier>().OrderBy(c => c.Salary);
        }
    }
}
