namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class ConsumerManager : СustomerManager, ICustomerManager
    {
<<<<<<< HEAD
        public ConsumerManager(IStorage storage, ICurrencyService converter) : base(storage, converter)
=======
        public ConsumerManager(IStorage storage, ILogger logger) : base(storage, logger)
>>>>>>> main
        {
        }
    }
}