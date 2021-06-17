namespace PastriesDelivery
{
    public interface ICacheService
    {
        Pastry Get(int id, int amount);
        void Set(Product product);
    }
}