namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class ConsumerManager : СustomerManager, ICustomerManager
    {
        public BusinessClientManager(IStorage storage, ICurrencyService converter,  ILogger logger) : base(storage, converter, logger)
        {
        }
    }
}