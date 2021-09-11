using EFCore.Data.Interfaces;
using EntityFrameworkTask;
using System.Collections.Generic;

namespace PastriesDelivery.Services
{
    public class CategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> GetAll()
        {
            return _unitOfWork.Categories.GetAll();
        }
    }
}