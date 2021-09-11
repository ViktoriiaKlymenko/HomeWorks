using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using PastriesDelivery.Contracts;
using System.Collections.Generic;

namespace PastriesDelivery.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _unitOfWork.Categories.GetAll();
        }
    }
}