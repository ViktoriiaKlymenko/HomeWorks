using EFCore.Data.Interfaces;
using EntityFrameworkTask.Models;
using PastriesDelivery.Contracts;
using System.Collections.Generic;

namespace PastriesDelivery.Services
{
    public class ProviderService : IProviderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProviderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddProvider(Provider provider)
        {
            _unitOfWork.Providers.Add(provider);
            _unitOfWork.Complete();
        }

        public void UpdateProvider(Provider provider, Provider newProvider)
        {
            _unitOfWork.Providers.Update(provider, newProvider);
            _unitOfWork.Complete();
        }

        public void DeleteProvider(Provider provider)
        {
            _unitOfWork.Providers.Remove(provider);
        }

        public Provider GetProvider(int id)
        {
            return _unitOfWork.Providers.Get(id);
        }

        public IEnumerable<Provider> GetProviders()
        {
            return _unitOfWork.Providers.GetAll();
        }
    }
}