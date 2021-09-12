using EntityFrameworkTask;
using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFoodService.HtmlHelpers
{
    public class ProductHelper
    {
        public static HtmlString GetProductList(IEnumerable<Product> products)
        {
            var result = "<ul>";
            foreach (var product in products)
            {
                result = $"{result}<li>{product.Id}</li>" +
                    $"<li>{product.Name}</li>" +
                    $"<li>{product.Price}</li>" +
                    $"<li>{product.Amount}</li>" +
                    $"<li>{product.Weight}</li>" +
                    $"<li>{product.Category.Name}</li>" +
                    $"<li>{product.Provider.Name}</li>";
            }
            result = $"{result}</ul>";
            return new HtmlString(result);
        }
    }
}
