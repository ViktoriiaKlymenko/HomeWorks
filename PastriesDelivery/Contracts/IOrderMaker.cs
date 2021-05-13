namespace PastriesDelivery
{
    public interface IOrderMaker
    {
        Pastry ChooseProduct(int id, int amount);
    }
}