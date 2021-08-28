using EFCore.Data.Interfaces;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class ConsumerManager : СustomerManager, ICustomerManager
    {
        public ConsumerManager(IUnitOfWork unitOfWork, ILogger logger) : base(unitOfWork, logger)
        {
        }
    }
}