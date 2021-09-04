using EFCore.Data.Interfaces;
using EntityFrameworkTask;

namespace EFCore.Data
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(DataContext context) : base(context)
        {
        }
    }
}