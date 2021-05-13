namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with provider.
    /// </summary>
    public class BusinessProviderManager : IOffersMaker
    {
        private readonly IStorage _storage;

        public BusinessProviderManager(IStorage storage)
        {
            _storage = storage;
        }

        public void AddNewOffer(Pastry pastry, User user)
        {
            _storage.Pastries.Add(pastry);
            _storage.Type.Add(StorageType.AvailableProducts);
            _storage.Users.Add(user);
        }
    }
}