namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with provider.
    /// </summary>
    public class BusinessProviderManager : IOffersMaker
    {
        public Storage AddNewOffer(Storage storage, Pastry pastry, User user)
        {
            storage.Pastries.Add(pastry);
            storage.Type.Add(StorageType.AvailableProducts);
            storage.Users.Add(user);
            return storage;
        }
    }
}