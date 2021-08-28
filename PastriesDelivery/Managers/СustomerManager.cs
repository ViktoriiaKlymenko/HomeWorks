using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PastriesDelivery
{
    public class СustomerManager
    {
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly ILogger Logger;

        public СustomerManager(IUnitOfWork unitOfWork, ILogger logger)
        {
            UnitOfWork = unitOfWork;
            Logger = logger;
        }

        public Product ChooseProduct(int id, int amount)
        {
            var availableProducts = ExtractProducts();
            var product = availableProducts.FirstOrDefault(p => p.Id == id);

            if (amount > product.Amount || amount <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (amount < product.Amount)
            {
                UnitOfWork.Products.Find(p => p.Id == id).Amount -= amount;
                Logger.Log($"{amount} units of {product.ToString()} were removed from available products.");
                return product;
            }

            if (product.Amount == amount)
            {
                UnitOfWork.Products.Remove(availableProducts.FirstOrDefault(product => product.Id == id));
                Logger.Log($"{product.ToString()} was removed from available products.");
                return product;
            }

            return product;
        }

        public bool CheckForDataPrescence()
        {
            return UnitOfWork.Products.Count() is not 0;
        }

        public virtual void CreateOrder(Order order)
        {
            UnitOfWork.Orders.Add(order);
            Logger.Log($"{order.ToString()} was added to orders.");
        }

        public List<Product> ExtractProducts()
        {
            return UnitOfWork.Products.GetAll().ToList();
        }
    }
}