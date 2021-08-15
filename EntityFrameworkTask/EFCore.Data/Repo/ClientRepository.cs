using EntityFrameworkTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.Repo
{
    public class ClientRepository: BaseRepository<Client>
    {
        public ClientRepository(DataContext context) : base(context)
        {
        }
    }
}
