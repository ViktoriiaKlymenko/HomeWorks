using EFCore.Data;
using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data
{
    public class ClientRepository: BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(DataContext context): base(context)
        {
        }
    }
}
