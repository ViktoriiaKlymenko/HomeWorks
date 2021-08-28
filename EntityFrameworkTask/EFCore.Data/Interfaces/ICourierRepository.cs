using EntityFrameworkTask;
using System.Collections.Generic;

namespace EFCore.Data.Interfaces
{
    public interface ICourierRepository: IBaseRepository<Courier>
    {
        public IEnumerable<Courier> SortBySalary();
    }
}
