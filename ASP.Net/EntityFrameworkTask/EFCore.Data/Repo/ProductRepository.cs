using EFCore.Data;
using EntityFrameworkTask;
using EntityFrameworkTask.EFCore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data
{
    public class ProductRepository: BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {

        }

        public void ChangeProductAmount(Product product, int newValue)
        {
            Context.Set<Product>().Update(product).CurrentValues.SetValues(product.Amount = newValue);
        }

        public void ChangeProductName(Product product, string newValue)
        {
            Context.Set<Product>().Update(product).CurrentValues.SetValues(product.Name = newValue);
        }

        public void ChangeProductPrice(Product product, decimal newValue)
        {
            Context.Set<Product>().Update(product).CurrentValues.SetValues(product.Price = newValue);
        }

        public void ChangeProductWeight(Product product, int newValue)
        {
            Context.Set<Product>().Update(product).CurrentValues.SetValues(product.Weight = newValue);
        }


    }
}
