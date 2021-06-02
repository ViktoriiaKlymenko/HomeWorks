namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
<<<<<<< HEAD
<<<<<<< HEAD
    public class ConsumerManager : СustomerManager, ICustomerManager
    {
        public ConsumerManager(IStorage storage) : base(storage)
        {
=======
    public class ConsumerManager : СustomerManager, IOrderMaker
=======
    public class ConsumerManager : СustomerManager, ICustomerManager
>>>>>>> b09788c (Code was improved.)
    {
        public ConsumerManager(IStorage storage) : base(storage)
        {
<<<<<<< HEAD
            _availableProducts = availableProducts;
            _userOrders = userOrders;
>>>>>>> 6503217 (Code was improved.)
=======
>>>>>>> b09788c (Code was improved.)
        }
    }
}