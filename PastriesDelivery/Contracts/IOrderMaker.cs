namespace PastriesDelivery
{
    public interface IOrderMaker
    {
        Pastry ChooseProduct(int id, int amount);

        public void SaveOrder(Pastry pastry);

        public void SaveUser(User businessClient);
    }
}