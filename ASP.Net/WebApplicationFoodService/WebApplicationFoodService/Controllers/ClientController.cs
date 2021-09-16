﻿using EntityFrameworkTask;
using Microsoft.AspNetCore.Mvc;
using PastriesDelivery.Services;
using System.Collections.Generic;

namespace WebApplicationFoodService.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        [HttpGet]
        public IEnumerable<Client> GetAll()
        {
            return _clientService.GetClients();
        }

        [HttpPost]
        public IActionResult CreateClient(Client client)
        {
            _clientService.AddClient(client);
            return new OkResult();
        }

        [HttpPut]
        public IActionResult UpdateClient(Client client, Client newClient)
        {
            _clientService.UpdateClient(client, newClient);
            return new OkResult();
        }

        [HttpDelete]
        public IActionResult DeleteClient(Client client)
        {
            _clientService.DeleteClient(client);
            return new OkResult();
        }
    }
}