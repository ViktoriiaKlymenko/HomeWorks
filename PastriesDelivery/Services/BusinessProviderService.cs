using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with provider.
    /// </summary>
    public class BusinessProviderService
    {
        private readonly IStorage _storage;
        private readonly ILogger _logger;
        private readonly ICacheService _cacheService;

        public BusinessProviderService(IStorage storage, ILogger logger, ICacheService cacheService)
        {
            _storage = storage;
            _logger = logger;
            _cacheService = cacheService;
        }

        public int SetId()
        {
            if (_storage.Products.Any())
            {
                return _storage.Products.Max(product => product.Pastry.Id) + 1;
            }
            return default;
        }

        public void CreateOffer(Pastry pastry, User user)
        {
            _storage.Products.Add(new Product(pastry, user));
        }
    }
}