using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Services;
using System.Collections.Generic;

namespace WebApplicationService.Controllers
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

        public IActionResult CreateClient(Client client)
        {
            _clientService.AddClient(client);
            return new OkResult();
        }

        public IActionResult UpdateClient(Client client, Client newClient)
        {
            _clientService.UpdateClient(client, newClient);
            return new OkResult();
        }

        public IActionResult DeleteClient(Client client)
        {
            _clientService.DeleteClient(client);
            return new OkResult();
        }
    }
}