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

        public int SetId()
        {
            int id = default;
            for (int i = 0; i < _storage.Pastries.Count; i++)
            {
                if (_storage.Type[i] == StorageType.AvailableProducts)
                {
                    var pastry = _storage.Pastries[i];

                    if (i < pastry.Id)
                    {
                        id = pastry.Id;
                    }
                }
            }
            return id;
        }

        public void AddNewOffer(Pastry pastry, User user)
        {
            _storage.Pastries.Add(pastry);
            _storage.Type.Add(StorageType.AvailableProducts);
            _storage.Users.Add(user);
        }
    }
}