using System.Linq;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class BusinessClientManager : СustomerManager, IOrderMaker
    {
        private readonly IStorage _userOrders;

        public BusinessClientManager(IStorage availableProducts, IStorage userOrders) : base(availableProducts, userOrders)
        {
            _userOrders = userOrders;
        }

        public override void  SaveOrder(Pastry pastry)
        {
<<<<<<< HEAD
            pastry.Price *= pastry.Amount;
            ApplyDiscount(pastry);
            _userOrders.Pastries.Add(pastry);
        }


        private static Pastry ApplyDiscount(Pastry pastry)
=======
            var totalPrice = ApplyDiscount(pastry);
            Storage.Orders.Add(new Order(pastry, user, totalPrice));
        }

        private decimal ApplyDiscount(Pastry pastry)
>>>>>>> 532ba61 (Mistakes were fixed.)
        {
            decimal totalPrice = default;
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