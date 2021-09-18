namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class ConsumerManager : СustomerManager, ICustomerManager
    {
<<<<<<< HEAD
<<<<<<< HEAD
        public ConsumerManager(IStorage storage, ICurrencyService converter) : base(storage, converter)
=======
        public ConsumerManager(IStorage storage, ILogger logger) : base(storage, logger)
>>>>>>> main
=======
        public BusinessClientManager(IStorage storage, ICurrencyService converter,  ILogger logger) : base(storage, converter, logger)
>>>>>>> b570995b4acb0dc6aa8f439c08b1c3f6635fcf8c
        {
        }
    }
}