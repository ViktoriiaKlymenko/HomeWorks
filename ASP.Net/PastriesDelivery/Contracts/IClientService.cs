using EntityFrameworkTask;
using System.Collections.Generic;

namespace PastriesDelivery.Services
{
    public interface IClientService
    {
        void AddClient(Client client);
        void UpdateClient(Client client, Client newClient);
        void DeleteClient(Client client);
        Client GetClient(int id);
        IEnumerable<Client> GetClients();
    }
}