using System.Linq;

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
<<<<<<< HEAD

=======
>>>>>>> 532ba61 (Mistakes were fixed.)
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
<<<<<<< HEAD

=======
>>>>>>> 532ba61 (Mistakes were fixed.)
            return totalPrice;
        }
    }
}