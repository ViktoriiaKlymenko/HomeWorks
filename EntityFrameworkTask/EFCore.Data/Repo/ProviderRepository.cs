using EntityFrameworkTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Repo
{
    public class ProviderRepository: BaseRepository<Provider>
    {
        public ProviderRepository(DataContext context) : base(context)
        {
        }
    }
}
