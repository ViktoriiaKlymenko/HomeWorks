using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System.Collections.Generic;
using System.Linq;

namespace EFCore.Data.Repo
{
    public class CourierRepository : BaseRepository<Courier>, ICourierRepository
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