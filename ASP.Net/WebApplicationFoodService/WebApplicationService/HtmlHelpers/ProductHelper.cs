using EntityFrameworkTask;
using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationFoodService.HtmlHelpers
{
    public class ProductHelper
    {
        public static HtmlString GetProductList(IEnumerable<Product> products)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder = stringBuilder.Append($"<ul>");

            foreach (var product in products)
            {
                stringBuilder = stringBuilder.Append($"<li> {product.Id} </li>");
                stringBuilder = stringBuilder.Append($"<li> {product.Name} </li>");
                stringBuilder = stringBuilder.Append($"<li> {product.Price} </li>");
                stringBuilder = stringBuilder.Append($"<li> {product.Amount} </li>");
                stringBuilder = stringBuilder.Append($"<li> {product.Weight} </li>");
                stringBuilder = stringBuilder.Append($"<li> {product.Category.Name} </li>");
                stringBuilder = stringBuilder.Append($"<li> {product.Provider.Name} </li>");
            }
            stringBuilder = stringBuilder.Append($"</ul>");
            return new HtmlString(stringBuilder.ToString());
        }
    }
}
