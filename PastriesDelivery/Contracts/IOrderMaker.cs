namespace PastriesDelivery
{
    public interface IOrderMaker
    {
        Pastry ChooseProduct(string idAndAmount);
        public bool CheckForDataPrescence();
        string ConfirmOrder();
    }
}