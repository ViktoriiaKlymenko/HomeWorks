using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with provider.
    /// </summary>
    public class BusinessProviderManager
    {
        private readonly IStorage _availableProducts;

        public BusinessProviderManager(IStorage availableProducts)
        {
            _availableProducts = availableProducts;
        }

        public int SetId()
        {
            int id = default;
<<<<<<< HEAD

            if (_storage.Products.Any())
            {
                return id = _storage.Products.Max(products => products.Pastry.Id) + 1;
=======
            if (_availableProducts.Pastries.Count is not 0)
            {
                return id = _availableProducts.Pastries.Max(pastry => pastry.Id) + 1;
>>>>>>> 6503217 (Code was improved.)
            }

            return id;
        }

        public void CreateOffer(Pastry pastry, User user)
        {
<<<<<<< HEAD
            _storage.Products.Add(new Product(pastry, user));
=======
            _availableProducts.Pastries.Add(pastry);
            _availableProducts.Users.Add(user);
>>>>>>> 6503217 (Code was improved.)
        }
    }
}