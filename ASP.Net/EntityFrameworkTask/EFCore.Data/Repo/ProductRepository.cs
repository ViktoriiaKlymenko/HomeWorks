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
    }
}
