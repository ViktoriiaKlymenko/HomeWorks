using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Services;
using System.Collections.Generic;

namespace WebApplicationFoodService.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public IEnumerable<Client> GetAll()
        {
            return _clientService.GetClients();
        }

        public Client GetById(int id)
        {
            return _clientService.GetClient(id);
        }

        public void CreateClient(Client client)
        {
            _clientService.AddClient(client);
        }

        public void UpdateClient(Client client, Client newClient)
        {
            _clientService.UpdateClient(client, newClient);
        }

        public void DeleteClient(Client client)
        {
            _clientService.DeleteClient(client);
        }
    }
}