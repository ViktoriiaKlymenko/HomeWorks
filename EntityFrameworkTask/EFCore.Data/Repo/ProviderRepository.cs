using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Repo
{
    public class ProviderRepository: BaseRepository<Provider>, IProviderRepository
    {
        public ProviderRepository(DataContext context) : base(context)
        {
        }

        public IEnumerable<string> GetAllNames()
        {
            return Context.Set<Provider>().Select(p => p.Name);
        }

    }
}
