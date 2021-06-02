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
            var totalPrice = ApplyDiscount(pastry);
            Storage.Orders.Add(new Order(pastry, user, totalPrice));
        }

        private decimal ApplyDiscount(Pastry pastry)
        {
            decimal totalPrice = default;

            if (pastry.Amount > 19 && pastry.Amount < 50)
            {
                totalPrice -= pastry.Price / 100 * (int)DiscountPercentEnum.TwentyUnits;
            }

            if (pastry.Amount > 49 && pastry.Amount < 100)
            {
                totalPrice -= pastry.Price / 100 * (int)DiscountPercentEnum.FiftyUnits;
            }

            if (pastry.Amount > 99)
            {
                totalPrice -= pastry.Price / 100 * (int)DiscountPercentEnum.HundredUnits;
            }

            return totalPrice;
        }
    }
}