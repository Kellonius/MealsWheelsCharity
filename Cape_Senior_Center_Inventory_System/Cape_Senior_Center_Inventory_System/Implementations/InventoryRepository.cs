using Cape_Senior_Center_Inventory_System.DataContext.Models;
using Cape_Senior_Center_Inventory_System.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cape_Senior_Center_Inventory_System.Implementations
{
    public class InventoryRepository : IInventoryRepository
    {
        protected IUnitOfWork unitOfWork;
        public InventoryRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Inventory Add(Inventory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Inventory entity)
        {
            throw new NotImplementedException();
        }

        public IList<Inventory> GetAll()
        {
            return unitOfWork.DataContext.Inventories.ToList();
        }

        public Inventory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Inventory Update(Inventory entity)
        {
            throw new NotImplementedException();
        }
    }
}
