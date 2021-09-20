using EntityFrameworkTask.Models;
using System.Collections.Generic;

namespace PastriesDelivery.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
    }
}