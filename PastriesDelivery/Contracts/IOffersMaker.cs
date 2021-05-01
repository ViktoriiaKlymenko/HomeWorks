namespace PastriesDelivery
{
    public interface IOffersMaker
    {
        AvailableProducts AddNewOffer(AvailableProducts availableProducts, Pastry pastry);
        string ConfirmOffer();
        AvailableProducts AcceptData(AvailableProducts availableProducts, Pastry pastry);
    }
}