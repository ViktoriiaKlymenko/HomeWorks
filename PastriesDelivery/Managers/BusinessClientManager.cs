namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class BusinessClientManager : СustomerManager, ICustomerManager
    {
        public BusinessClientManager(IStorage storage) : base(storage)
        {
        }

        public override void CreateOrder(Pastry pastry, User user)
        {
            pastry = ApplyDiscount(pastry);
            Storage.Orders.Add(new Order(pastry, user, pastry.Price * pastry.Amount));
        }

        private static Pastry ApplyDiscount(Pastry pastry)
        {
            if (pastry.Amount > 19 && pastry.Amount < 50)
            {
                pastry.Price -= pastry.Price / 100 * (int)DiscountPercents.TwentyUnits;
            }
            if (pastry.Amount > 49 && pastry.Amount < 100)
            {
                pastry.Price -= pastry.Price / 100 * (int)DiscountPercents.FiftyUnits;
            }
            if (pastry.Amount > 99)
            {
                pastry.Price -= pastry.Price / 100 * (int)DiscountPercents.HundredUnits;
            }
            return pastry;
        }
    }
}