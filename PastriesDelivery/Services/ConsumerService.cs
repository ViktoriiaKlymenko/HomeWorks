namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class ConsumerService : СustomerService, ICustomerManager
    {
        public ConsumerService(IStorage storage, ILogger logger, ICacheService cacheSevice) : base(storage, logger, cacheSevice)
        {
        }
    }
}