using EFCore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTask.EFCore.Data.Interfaces
{
    public interface IProductRepository: IBaseRepository<Product>
    {
        void ChangeProductAmount(Product product, int newValue);
        void ChangeProductName(Product product, string newValue);
        void ChangeProductPrice(Product product, decimal newValue);
        void ChangeProductWeight(Product product, int newValue);
    }
}
