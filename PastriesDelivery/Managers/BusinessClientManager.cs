using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
<<<<<<< HEAD
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
=======
    public class BusinessClientManager : СustomerManager, IOrderMaker
    {
        private readonly IStorage _userOrders;

        public BusinessClientManager(IStorage availableProducts, IStorage userOrders) : base(availableProducts, userOrders)
        {
            _userOrders = userOrders;
        }

        public override void  SaveOrder(Pastry pastry)
        {
            pastry.Price *= pastry.Amount;
            ApplyDiscount(pastry);
            _userOrders.Pastries.Add(pastry);
        }

>>>>>>> 6503217 (Code was improved.)

            if (pastry.Amount > 19 && pastry.Amount < 50)
            {
                totalPrice -= pastry.Price / 100 * (int)DiscountPercents.TwentyUnits;
            }

            if (pastry.Amount > 49 && pastry.Amount < 100)
            {
                totalPrice -= pastry.Price / 100 * (int)DiscountPercents.FiftyUnits;
            }

            if (pastry.Amount > 99)
            {
                totalPrice -= pastry.Price / 100 * (int)DiscountPercents.HundredUnits;
            }

            return totalPrice;
        }
    }
}