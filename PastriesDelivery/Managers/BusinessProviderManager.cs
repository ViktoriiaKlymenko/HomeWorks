using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with provider.
    /// </summary>
    public class BusinessProviderManager : IOffersMaker
    {
        private readonly IStorage _availableProducts;

        public BusinessProviderManager(IStorage availableProducts)
        {
            _availableProducts = availableProducts;
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
            _availableProducts.Users.Add(user);
        }
    }
}