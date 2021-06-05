namespace PastriesDelivery
{
    public interface ICacheService
    {
        Pastry GetFromCache(int id, int amount);
        void SaveToCache(Product product);
    }
}