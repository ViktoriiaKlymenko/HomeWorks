using EntityFrameworkTask;
using System.Collections.Generic;

namespace PastriesDelivery
{
    public interface IProductService
    {
        List<Product> ExtractProducts();
    }
}