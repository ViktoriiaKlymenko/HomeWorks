namespace PastriesDelivery
{
    public interface IOrderMaker
    {
        Pastry ChooseProduct(string idAndAmount, Storage storage);

        bool CheckForDataPrescence();
    }
}