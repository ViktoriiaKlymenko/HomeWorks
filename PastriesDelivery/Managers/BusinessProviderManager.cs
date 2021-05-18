using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with provider.
    /// </summary>
    public class BusinessProviderManager : IOffersMaker
    {
        private readonly IStorage _availableProducts;
        private readonly ILogger _logger;

        public BusinessProviderManager(IStorage availableProducts, ILogger logger)
        {
            _availableProducts = availableProducts;
            _logger = logger;
        }

        public int SetId()
        {
            int id = default;
            if (_availableProducts.Pastries.Count is not 0)
            {
                return id = _availableProducts.Pastries.Max(pastry => pastry.Id) + 1;
            }
            return id;
        }

        public void AddNewOffer(Pastry pastry, User user)
        {
            _availableProducts.Pastries.Add(pastry);
            _logger.LogChanges(StorageType.AvailableProducts, pastry.GetType(), pastry.ToString(), "was added");
            _availableProducts.Users.Add(user);
        }
    }
}