using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
<<<<<<< HEAD
    public class ConsumerManager : СustomerManager, ICustomerManager
    {
        public ConsumerManager(IStorage storage) : base(storage)
        {
=======
    public class ConsumerManager : СustomerManager, IOrderMaker
    {
        private readonly IStorage _availableProducts;
        private readonly IStorage _userOrders;

        public ConsumerManager(IStorage availableProducts, IStorage userOrders) : base(availableProducts, userOrders)
        {
            _availableProducts = availableProducts;
            _userOrders = userOrders;
>>>>>>> 6503217 (Code was improved.)
        }
    }
}