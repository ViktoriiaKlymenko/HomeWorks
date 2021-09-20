using EntityFrameworkTask.Models;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Contracts;
using System.Collections.Generic;

namespace WebApplicationService.Controllers
{
    [Controller]
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IEnumerable<Client> GetAll()
        {
            return _clientService.GetClients();
        }

        [HttpPost]
        public IActionResult CreateClient(Client client)
        {
            _clientService.AddClient(client);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateClient(Client client, Client newClient)
        {
            _clientService.UpdateClient(client, newClient);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteClient(Client client)
        {
            _clientService.DeleteClient(client);
            return Ok();
        }
    }
}