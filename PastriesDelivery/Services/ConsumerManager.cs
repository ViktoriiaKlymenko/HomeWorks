namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class ConsumerManager : СustomerManager, ICustomerManager
    {
        public ConsumerManager(IStorage storage, ILogger logger, ICacheService cacheSevice) : base(storage, logger, cacheSevice)
        {
        }
    }
}