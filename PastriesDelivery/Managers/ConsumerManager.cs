using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class ConsumerManager : СustomerManager, IOrderMaker
    {
        private readonly IStorage _availableProducts;
        private readonly IStorage _userOrders;
        private readonly ILogger _logger;

        public ConsumerManager(IStorage availableProducts, IStorage userOrders, ILogger logger) : base(availableProducts, userOrders, logger)
        {
            _availableProducts = availableProducts;
            _userOrders = userOrders;
            _logger = logger;
        }
    }
}