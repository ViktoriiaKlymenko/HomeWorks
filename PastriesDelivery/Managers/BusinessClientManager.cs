using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class BusinessClientManager : СustomerManager, ICustomerManager
    {
<<<<<<< HEAD
<<<<<<< HEAD
        public BusinessClientManager(IStorage storage, ICurrencyService converter) : base(storage, converter)
=======
        public BusinessClientManager(IStorage storage, ILogger logger) : base(storage, logger)
>>>>>>> main
=======
        public BusinessClientManager(IStorage storage, ICurrencyService converter,  ILogger logger) : base(storage, converter, logger)
>>>>>>> b570995b4acb0dc6aa8f439c08b1c3f6635fcf8c
        {
        }

        public override Order CreateOrder(Pastry pastry, User user)
        {
            var totalPrice = ApplyDiscount(pastry);
            Storage.Orders.Add(new Order(pastry, user, totalPrice));
            return Storage.Orders.Last();
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