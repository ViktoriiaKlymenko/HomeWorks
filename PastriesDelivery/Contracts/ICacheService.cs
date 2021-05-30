namespace PastriesDelivery
{
    public interface ICacheService
    {
        Pastry ExtractFromCache(int id, int amount);
        void SaveToCache(Product product);
    }
}