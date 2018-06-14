using Cape_Senior_Center_Inventory_System.DataContext.Models;
using Cape_Senior_Center_Inventory_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cape_Senior_Center_Inventory_System.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        protected IUnitOfWork unitOfWork;
        public CategoryRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Category Add(Category entity)
        {
            //var result = this.unitOfWork.DataContext.Categories.Add(entity);
            //this.unitOfWork.DataContext.SaveChanges();
            //return result;
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            //this.unitOfWork.DataContext.Categories.Remove(entity);
            //this.unitOfWork.DataContext.SaveChanges();
            throw new NotImplementedException();
        }

        public IList<Category> GetAll()
        {
            return this.unitOfWork.DataContext.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return unitOfWork.DataContext.Categories.FirstOrDefault(x => x.Id.Equals(id));
        }

        public Category Update(Category entity)
        {
            //var result = unitOfWork.DataContext.Categories.FirstOrDefault(x => x.Id.Equals(entity.Id));
            //if (result == null)
            //{
            //    return null;
            //}
            //this.unitOfWork.DataContext.Entry(result).CurrentValues.SetValues(entity);
            //this.unitOfWork.DataContext.SaveChanges();
            //return result;
            throw new NotImplementedException();
        }
    }
}
