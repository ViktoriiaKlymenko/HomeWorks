using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with provider.
    /// </summary>
    public class BusinessProviderManager
    {
        private readonly IStorage _storage;

        public BusinessProviderManager(IStorage storage)
        {
            _storage = storage;
        }

        public int SetId()
        {
            int id = default;

            if (_storage.Products.Any())
            {
                return id = _storage.Products.Max(products => products.Pastry.Id) + 1;
            }

            return id;
        }

        public void CreateOffer(Pastry pastry, User user)
        {
            _storage.Products.Add(new Product(pastry, user));
        }
    }
}