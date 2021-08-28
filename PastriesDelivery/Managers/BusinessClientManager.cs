using EFCore.Data.Interfaces;
using EFCore.Data.Repo;
using EntityFrameworkTask;

namespace PastriesDelivery
{
    /// <summary>
    /// This class contains methods intended for work with consumer.
    /// </summary>
    public class BusinessClientManager : СustomerManager, ICustomerManager
    {
        private const int twentyUnitsConstant = 3;
        private const int fiftyUnitsConstant = 4;
        private const int hundredUnitsConstant = 5;
        public BusinessClientManager(IUnitOfWork unitOfWork, ILogger logger) : base(unitOfWork, logger)
        {
        }

        public override void CreateOrder(Order order)
        {
            var totalPrice = ApplyDiscount(order);
            UnitOfWork.Orders.Add(order);
        }

        private Order ApplyDiscount(Order order)
        {
            if (UnitOfWork.Products.Find(p => p.Id == order.ProductId).Amount > 19 && UnitOfWork.Products.Find(p => p.Id == order.ProductId).Amount < 50)
            {
                order.TotalPrice -= order.TotalPrice / 100 * twentyUnitsConstant;
            }

            if (UnitOfWork.Products.Find(p => p.Id == order.ProductId).Amount > 49 && UnitOfWork.Products.Find(p => p.Id == order.ProductId).Amount < 100)
            {
                order.TotalPrice -= order.TotalPrice / 100 * fiftyUnitsConstant;
            }

            if (UnitOfWork.Products.Find(p => p.Id == order.ProductId).Amount > 99)
            {
                order.TotalPrice -= order.TotalPrice / 100 * hundredUnitsConstant;
            }

            return order;
        }
    }
}