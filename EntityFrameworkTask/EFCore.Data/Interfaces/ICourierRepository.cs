using EntityFrameworkTask;
using System.Collections.Generic;

namespace EFCore.Data.Interfaces
{
    public interface ICourierRepository
    {
        public IEnumerable<Courier> SortBySalary();
    }
}
