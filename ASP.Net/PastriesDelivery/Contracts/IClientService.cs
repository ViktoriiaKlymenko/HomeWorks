using EntityFrameworkTask.Models;
using System.Collections.Generic;

namespace PastriesDelivery.Contracts
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