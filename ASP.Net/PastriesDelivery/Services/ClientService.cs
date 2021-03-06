using EFCore.Data.Interfaces;
using EntityFrameworkTask.Models;
using PastriesDelivery.Contracts;
using System.Collections.Generic;

namespace PastriesDelivery.Services
{
    public class ClientService : IClientService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddClient(Client client)
        {
            _unitOfWork.Clients.Add(client);
            _unitOfWork.Complete();
        }

        public void UpdateClient(Client client, Client newClient)
        {
            _unitOfWork.Clients.Update(client, newClient);
            _unitOfWork.Complete();
        }

        public void DeleteClient(Client client)
        {
            _unitOfWork.Clients.Remove(client);
        }

        public Client GetClient(int id)
        {
            return _unitOfWork.Clients.Get(id);
        }

        public IEnumerable<Client> GetClients()
        {
            return _unitOfWork.Clients.GetAll();
        }
    }
}