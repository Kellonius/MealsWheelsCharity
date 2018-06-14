using Cape_Senior_Center_Inventory_System.DataContext.Models;
using Cape_Senior_Center_Inventory_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        protected IUnitOfWork unitOfWork;
        public CategoryRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IList<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById()
        {
            throw new NotImplementedException();
        }
    }
}
