namespace PastriesDelivery
{
    public interface IOffersMaker
    {
        Storage AddNewOffer(Storage storage, Pastry pastry, User user);
    }
}