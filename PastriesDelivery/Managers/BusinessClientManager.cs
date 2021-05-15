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
            pastry.Price *= pastry.Amount;
            ApplyDiscount(pastry);
            _userOrders.Pastries.Add(pastry);
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