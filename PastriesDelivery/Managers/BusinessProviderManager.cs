using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with provider.
    /// </summary>
    public class BusinessProviderManager
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public BusinessProviderManager(IUnitOfWork unitOfWork, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        public void CreateOffer(Product product, Provider provider)
        {
            _unitOfWork.Products.Add(product);
        }
    }
}