using System.Collections.Generic;

namespace PastriesDelivery
{
    public interface ICustomerManager
    {
        List<Product> ExtractProducts();

        decimal ConvertToUSD(decimal totalPrice);
    }
}